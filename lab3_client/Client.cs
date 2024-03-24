using System;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_client
{
    class Client
    {
        private Socket clientSock;


        public Client()
        {
            clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void connect(string ip, int port)
        {
            clientSock.Connect(ip, port);

        }

        public void sendMessage(string header, string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(header+str);
            clientSock.Send(data);
        }

        public string getMessage()
        {
            string str = "";

            if (clientSock.Poll(100, SelectMode.SelectRead))
            {
                if (!clientSock.Connected)
                {
                    str="!!!Сервер отключился(!!!";
                }
                else
                {
                    byte[] data = new byte[512];
                    int bytes = clientSock.Receive(data);

                    str = Encoding.UTF8.GetString(data, 0, bytes);
                }
            }
            return str;
        }
    }
}

