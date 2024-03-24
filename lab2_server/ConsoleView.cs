using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_server
{
    class ConsoleView : InterfaceConsoleView
    {
        public void clientLeaveSignal(string login)
        {
            Console.WriteLine(login + " отключился");
        }

        public void clentMessageSignal(string login)
        {
            Console.WriteLine(login + " отправил сообщение в чат");
        }

        public void waitingMes(string endPoint){
            Console.WriteLine("Сервер ожидает подключение на " + endPoint);
        }

        public void clientConnectedSignal(string endPoint)
        {
            Console.WriteLine("Подключён клиент: " + endPoint);
        }
    }
}
