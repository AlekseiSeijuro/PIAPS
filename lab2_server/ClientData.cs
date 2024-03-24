using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace lab2_server
{
    class ClientData
    {
        public Socket socket;
        public string login;
        public string password;
        public bool online;
        
    }
}
