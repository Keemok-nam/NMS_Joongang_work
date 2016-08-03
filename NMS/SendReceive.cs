using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace NMS
{
    public delegate void ReceivedEvent(SendReceive SendRecv, byte[] buffer, int lng);
    public delegate void CloseEvent(SendReceive SendRecv);

    class AsyncSocketData
    {
        public Socket AsyncSocket;
        public byte[] Buffer;
        public AsyncSocketData()
        {
            AsyncSocket = null;
            Buffer = null;
        }
    };

    public class SendReceive
    {
        public event ReceivedEvent Received = null;
        public event CloseEvent Closed = null;

        /// <summary>
        /// 진짜 소켓
        /// </summary>
        private Socket mSocket;

        private byte ServerID;
        private byte ClientID;
        private byte MyID;

        public void SetServerID(byte ServerID) { this.ServerID = ServerID; }
        public byte GetServerID() { return ServerID; }

        public void SetClientID(byte ClientID) { this.ClientID = ClientID; }
        public byte GetClientID() { return ClientID; }

        public void SetMyID(byte MyID) { this.MyID = MyID; }
        public byte GetMyID() { return MyID; }

        private int rCntMsg = 0;
        private byte[] rBufMsg = new byte[256];

        private bool flagSTX = new bool();
        private bool flagETX = new bool();
        private int cntETX = new int();

        /// <summary>
        /// 연결되었는지 여부
        /// </summary>
        public bool Connected
        {
            get
            {
                return (mSocket != null) ? (mSocket.Connected) : (false);
            }
        }

        /// <summary>
        /// 자신의 주소
        /// </summary>
        public EndPoint LocalEndPoint
        {
            get
            {
                return (mSocket != null) ? (mSocket.LocalEndPoint) : (null);
            }
        }

        /// <summary>
        /// 상대방 주소
        /// </summary>
        public EndPoint RemoteEndPoint
        {
            get
            {
                return (mSocket != null) ? (mSocket.RemoteEndPoint) : (null);
            }
        }

        /// <summary>
        /// 수신을 시작한다. 이 메소드는, 클라이언트 측에서는 AsyncConnectCallback() 내에서 사용되고, 서버 측에서는 Accepted 이벤트 함수에서 사용한다.
        /// </summary>
        /// <param name="socket">접속된 소켓</param>
        public void Start(Socket sock)
        {
            try
            {
                mSocket = sock;

                byte[] buffer = new byte[8192];
                AsyncSocketData ad = new AsyncSocketData();
                ad.AsyncSocket = mSocket;
                ad.Buffer = buffer;
                mSocket.BeginReceive(ad.Buffer, 0, 8192, SocketFlags.None, new AsyncCallback(ReceiveCallBack), ad);
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
                mSocket.BeginReceive(asd.Buffer, 0, 8192, SocketFlags.None, new AsyncCallback(ReceiveCallBack), asd);
            }
            catch
            {
                // write exception message.
                //Console.WriteLine(exption.Message);
                // close socket and dispose byte []
                asd.AsyncSocket.Close();
                asd.Buffer = null;

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
                                    this.Received(this, rBufMsg, rCntMsg);
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

        private void FireClosed()
        {
            if (mSocket != null) mSocket.Close();
            
            if (this.Closed != null)
                this.Closed(this);
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
                    ad.AsyncSocket = mSocket;
                    ad.Buffer = buffer;

                    mSocket.BeginSend(buffer, 0, lng, SocketFlags.None, new AsyncCallback(SendCallBack), ad);
                    //mSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), ad);
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
                        this.FireClosed();
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
                    mSocket.Shutdown(SocketShutdown.Both);
                    mSocket.Close();
                }
            }
            catch
            { }
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
