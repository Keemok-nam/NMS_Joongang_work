using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace NMS
{
    public delegate void AcceptedEvent(Socket sock);

    public class ServerSocket
    {
        public event AcceptedEvent Accepted = null;

        private Socket sSocket;

        public void Start(EndPoint localEndPoint)
        {
            sSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sSocket.Bind(localEndPoint);
            sSocket.Listen(0);

            sSocket.BeginAccept(new AsyncCallback(this.AsyncAcceptCallback), this);
        }

        private void AsyncAcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket sock = sSocket.EndAccept(ar);
                this.FireAccepted(sock);

                sSocket.BeginAccept(new AsyncCallback(this.AsyncAcceptCallback), this);
            }
            catch
            {
            }
        }

        private void FireAccepted(Socket sock)
        {
            if (this.Accepted != null)
                this.Accepted(sock);
        }

        public void Stop()
        {
            try
            {
                sSocket.Close();
            }
            catch
            {
            }
        }
    }
}
