using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_server
{
    interface InterfaceConsoleView
    {
        void clientLeaveSignal(string login);
        void clentMessageSignal(string login);
        void waitingMes(string endPoint);
        void clientConnectedSignal(string endPoint);
    }
}
