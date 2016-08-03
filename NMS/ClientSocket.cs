using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace NMS
{
    public delegate void ClientConnectedEvent(ClientSocket cSock);
    public delegate void ClientReceivedEvent(byte[] buffer, int lng);
    public delegate void ClientCloseEvent(ClientSocket cSock);

    public class ClientSocket
    {
        private string clientSocketVersion = "Ver 1.01";

        public event ClientConnectedEvent connectEvent = null;
        public event ClientReceivedEvent receivedEvent = null;
        public event ClientCloseEvent closedEvent = null;

        private Socket cSocket = null;

        private string remoteIPPort = null;

        public byte MyID;

        private int rCntMsg = 0;
        private byte[] rBufMsg = new byte[256];

        private bool flagSTX = new bool();
        private bool flagETX = new bool();
        private int cntETX = new int();

        public void SetcSocket() { this.cSocket = null; }

        public void Start(EndPoint remoteEndPoint)
        {
            if (cSocket != null) cSocket.Close();

            try
            {
                IPEndPoint tmpIPEndPoint = (IPEndPoint)remoteEndPoint;
                remoteIPPort = tmpIPEndPoint.Address.ToString() + ", " + tmpIPEndPoint.Port.ToString(); 

                cSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                cSocket.BeginConnect(remoteEndPoint, new AsyncCallback(this.AsyncConnectCallback), this);
            }
            catch
            {
            }
        }

        private void AsyncConnectCallback(IAsyncResult ar)
        {
            try
            {
                cSocket.EndConnect(ar);
                this.FireConnected();
            }
            catch
            {
            }
        }

        private void FireConnected()
        {
            try
            {
                if (this.connectEvent != null)
                {
                    this.connectEvent(this);
                    ReceiveStart();

                    //SetKeepAlive();
                }
            }
            catch
            {
            }
        }

        private void SetKeepAlive()
        {
            int keep_alive_time = 5000;
            int keep_alive_interval = 1000;

            System.IO.MemoryStream in_vals_stream = new System.IO.MemoryStream();
            System.IO.BinaryWriter writer = new System.IO.BinaryWriter(in_vals_stream);

            writer.Write(1);
            writer.Write(keep_alive_time);
            writer.Write(keep_alive_interval);

            try
            {
                byte[] keep_alive_values = in_vals_stream.ToArray();
                cSocket.IOControl(IOControlCode.KeepAliveValues, keep_alive_values, null);
            }
            catch
            {
            }
            finally
            {
                in_vals_stream.Dispose();
            }
        }

        /// <summary>
        /// 연결되었는지 여부
        /// </summary>
        public bool Connected
        {
            get
            {
                return (cSocket != null) ? (cSocket.Connected) : (false);
            }
        }

        /// <summary>
        /// 자신의 주소
        /// </summary>
        public EndPoint LocalEndPoint
        {
            get
            {
                return (cSocket != null) ? (cSocket.LocalEndPoint) : (null);
            }
        }

        /// <summary>
        /// 상대방 주소
        /// </summary>
        public EndPoint RemoteEndPoint
        {
            get
            {
                return (cSocket != null) ? (cSocket.RemoteEndPoint) : (null);
            }
        }

        /// <summary>
        /// 수신을 시작한다.
        /// </summary>
        /// <param name="socket">접속된 소켓</param>
        private void ReceiveStart()
        {
            try
            {
                byte[] buffer = new byte[8192];
                AsyncSocketData ad = new AsyncSocketData();
                ad.AsyncSocket = cSocket;
                ad.Buffer = buffer;
                cSocket.BeginReceive(ad.Buffer, 0, 8192, SocketFlags.None, new AsyncCallback(ReceiveCallBack), ad);
            }
            catch
            {
                // 연결 실패를 알린다.
                //OnConnectFailed(ee);
            }
        }

        /// <summary>
        /// 비동기 수신 처리
        /// </summary>
        /// <param name="ar"></param>
        private void ReceiveCallBack(IAsyncResult ar)
        {
            AsyncSocketData asd = (AsyncSocketData)ar.AsyncState;

            try
            {
                // check receive data. size.
                int recv = asd.AsyncSocket.EndReceive(ar);
                if (recv == 0)
                    this.FireClosed();

                //수신된 Data : asd.Buffer
                this.FireReceived(asd.Buffer, recv);

                //Console.WriteLine("EchoServer Received {0} Bytes , {1} ", recv, Encoding.Default.GetString(asd.Buffer, 0, recv));
                cSocket.BeginReceive(asd.Buffer, 0, 8192, SocketFlags.None, new AsyncCallback(ReceiveCallBack), asd);
            }
            catch
            {
                // write exception message.
                //Console.WriteLine(exption.Message);
                // close socket and dispose byte []
                asd.AsyncSocket.Close();
                asd.Buffer = null;

                //Error 이벤트 발생
                this.FireClosed();
            }
        }

        private void FireReceived(byte[] buffer, int lng)
        {
            for (int i = 0; i < lng; i++)
            {
                switch (buffer[i])
                {
                    case clsCommon.SOM_CHK:
                        if (rBufMsg[rCntMsg - 1] == clsCommon.STX)
                        {   //바로전이 STX이면 Data 시작
                            flagSTX = true;
                            flagETX = false;

                            rCntMsg = 0;
                            rBufMsg[rCntMsg++] = clsCommon.STX;
                            rBufMsg[rCntMsg++] = buffer[i];
                        }
                        else
                            rBufMsg[rCntMsg++] = buffer[i];

                        rCntMsg = rCntMsg % 256;
                        break;

                    case clsCommon.ETX:
                        if (rCntMsg > 5)
                        {
                            if (rBufMsg[5] < rCntMsg - 5)
                                flagETX = true;
                        }

                        rBufMsg[rCntMsg++] = buffer[i];
                        rCntMsg = rCntMsg % 256;
                        break;

                    default:
                        rBufMsg[rCntMsg++] = buffer[i];
                        rCntMsg = rCntMsg % 256;

                        if (flagSTX && flagETX)
                        {
                            cntETX++;

                            if (cntETX >= 2)
                            {
                                flagETX = false;
                                cntETX = 0;

                                rBufMsg[rCntMsg] = 0;

                                try
                                {
                                    this.receivedEvent(rBufMsg, rCntMsg);
                                }
                                catch
                                {
                                }

                                flagSTX = false;
                                rCntMsg = 0;
                            }
                        }
                        break;
                }
            }
        }

        /*
        private void FireReceived(byte[] buffer, int lng)
        {
            for (int i = 0; i < lng; i++)
            {
                switch (buffer[i])
                {
                    case clsCommon.END:
                        try
                        {
                            this.receivedEvent(rBufMsg, rCntMsg);
                        }
                        catch
                        {
                        }

                        rCntMsg = 0;
                        break;

                    default:
                        rBufMsg[rCntMsg++] = buffer[i];
                        rCntMsg = rCntMsg % 256;
                        break;
                }
            }
        }
        */

        private void FireClosed()
        {
            try
            {
                if (cSocket != null) cSocket.Close();
            }
            catch
            {
            }

            if (this.closedEvent != null)
                this.closedEvent(this);
        }

        /// <summary>
        /// String Data 송신
        /// </summary>
        /// <param name="data_buffer"></param>
        public void StringSend(string strData)
        {
            byte[] tmpBuf = Encoding.Default.GetBytes(strData);
            Send(tmpBuf, tmpBuf.Length);
        }

        /// <summary>
        /// 비동기 송신 시도
        /// </summary>
        /// <param name="data_buffer"></param>
        public void Send(byte[] buffer, int lng)
        {
            AsyncSocketData ad = new AsyncSocketData();

            try
            {
                if (this.Connected)
                {
                    ad.AsyncSocket = cSocket;
                    ad.Buffer = buffer;

                    cSocket.BeginSend(buffer, 0, lng, SocketFlags.None, new AsyncCallback(SendCallBack), ad);
                    //cSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), ad);
                }
                else
                {
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 비동기 송신 처리
        /// </summary>
        /// <param name="ar"></param>
        private void SendCallBack(IAsyncResult ar)
        {
            AsyncSocketData asd = (AsyncSocketData)ar.AsyncState;

            try
            {
                if (this.Connected)
                {
                    int send = asd.AsyncSocket.EndSend(ar);
                    if (send == 0)
                    {
                        //Error 이벤트 발생
                        this.FireClosed();
                    }
                }
                else
                {
                }
            }
            catch
            {
                // write exception message.
                if (asd != null)
                {
                    // close socket and dispose byte []
                    if (asd.AsyncSocket != null)
                        asd.AsyncSocket.Close();

                    if (asd.Buffer != null)
                        asd.Buffer = null;

                    asd = null;

                    //Error 이벤트 발생
                    this.FireClosed();
                }

            }
        }

        /// <summary>
        /// 소켓을 닫습니다.
        /// </summary>
        public void Stop()
        {
            try
            {
                if (this.Connected)
                {
                    cSocket.Shutdown(SocketShutdown.Both);
                    cSocket.Close();
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 소켓을 닫습니다.
        /// </summary>
        public void Close()
        {
            this.FireClosed();
        }

        /*
        //
        // 기본 데이터 변환 메소드 목록
        //
        public byte[] EncodeString(string value)
        {
            return System.Text.Encoding.UTF8.GetBytes(value);
        }
        public string DecodeString(byte[] value)
        {
            return System.Text.Encoding.UTF8.GetString(value);
        }

        public byte[] EncodeInt32(Int32 value)
        {
            return System.BitConverter.GetBytes(value);
        }
        public Int32 DecodeInt32(byte[] value)
        {
            return System.BitConverter.ToInt32(value, 0);
        }

        public byte[] EncodeLong(long value)
        {
            return System.BitConverter.GetBytes(value);
        }
        public long DecodeLong(byte[] value)
        {
            return System.BitConverter.ToInt64(value, 0);
        }

        public byte[] EncodeDateTime(DateTime value)
        {
            return this.EncodeLong(value.Ticks);
        }
        public DateTime DecodeDateTime(byte[] value)
        {
            return new DateTime(this.DecodeLong(value));
        }
        */
    }
}
