using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_server
{
    class Message
    {
        private string mesHeader;
        private string mesBody;

        public Message(string s)
        {
            mesHeader = s.Substring(0, 2);
            mesBody = s.Substring(2, s.Length - 2);
        }

        public string getMesHeader()
        {
            return mesHeader;
        }

        public string getMesBody()
        {
            return mesBody;
        }

        public byte[] getBytes()
        {
            byte[] data = Encoding.UTF8.GetBytes(mesHeader+mesBody);
            return data;
        }
    }


}
