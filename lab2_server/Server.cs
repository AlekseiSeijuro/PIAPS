using System;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab2_server
{
    class Server
    {
        private List<ClientData> clients;
        private Socket serverSock;
        private Thread listeningDaemon, sendingOnlineDaemon;
        private bool isStarted;
        private InterfaceConsoleView CV;

        private object mutex;

        public Server(int port)
        {
            isStarted = false;
            clients = new List<ClientData>();
            listeningDaemon = new Thread(this.listenClients);
            sendingOnlineDaemon = new Thread(this.sendingOnlineList);
            mutex = new object();
            CV = new ConsoleView();

            serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, port);
            serverSock.Bind(ipPoint);
        }

        private void listenClients()
        {
            while (isStarted)
            {

                CV.waitingMes(""+serverSock.LocalEndPoint);

                serverSock.Listen(100);
                ClientData newClient = new ClientData();
                newClient.socket=serverSock.Accept();

                lock (mutex)
                {
                    clients.Add(newClient);
                }

                CV.clientConnectedSignal("" + clients[clients.Count - 1].socket.RemoteEndPoint);
            }
        }

        private void sendingOnlineList()
        {
            while (isStarted)
            {
                lock (mutex)
                {
                    string str = "";
                    foreach (ClientData client in clients)
                    {
                        if (client.online)str += client.login + "\r\n";
                    }

                    Message mesToSend = new Message("!$" + str);

                    byte[] data = mesToSend.getBytes();
                    //отправка пользователям списка клиентов
                    foreach (ClientData client in clients)
                    {
                        if(client.online)client.socket.Send(data);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        public void start()
        {
            isStarted = true;
            listeningDaemon.Start();
            sendingOnlineDaemon.Start();

            while (isStarted)
            {
                lock (mutex)
                {
                    ClientData oldUserData=null;
                    foreach (ClientData client in clients)
                    {
                        oldUserData = null;
                        if ((client.socket!=null)&&(client.socket.Poll(100, SelectMode.SelectRead)))
                        {
                            //Клиент отключился((
                            if (client.socket.Available==0)
                            {
                                client.socket = null;
                                client.online = false;
                                CV.clientLeaveSignal(client.login);
                            }
                            else
                            {
                                int bytes = client.socket.Available;
                                byte[] data = new byte[bytes];
                                client.socket.Receive(data);

                                string str = Encoding.UTF8.GetString(data, 0, bytes);
                                Message mes = new Message(str);

                                //сообщение об авторизации/регистрации
                                if (mes.getMesHeader() == "!@")
                                {
                                    string[] authData = mes.getMesBody().Split('@');


                                    bool unicLogin = true;
                                    bool registredUser = false;
                                    foreach (ClientData clientCheck in clients)
                                    {
                                        if ((clientCheck.login == authData[0])) unicLogin = false;
                                        if ((clientCheck.login == authData[0]) && (clientCheck.password == authData[1]))
                                        {
                                            oldUserData = clientCheck;
                                            registredUser = true;
                                        }
                                    }

                                    if(registredUser)
                                    {
                                        client.login = authData[0];
                                        client.password = authData[1];
                                        client.online = true;

                                        Message mesToSend = new Message("!><<< C возвращением " + client.login + "!!! >>>");

                                        data = mesToSend.getBytes();
                                        
                                        client.socket.Send(data);
                                        break;

                                    }
                                    else if (unicLogin)
                                    {
                                        client.login = authData[0];
                                        client.password = authData[1];
                                        client.online = true;

                                        Message mesToSend = new Message("!><<< " + client.login + " зарегистрировался на сервере. >>>");

                                        data = mesToSend.getBytes();

                                        foreach (ClientData targetClient in clients)
                                        {
                                            if(targetClient.online)targetClient.socket.Send(data);
                                        }
                                    }
                                    else if ((!registredUser)&& (!unicLogin)){

                                        Message mesToSend = new Message("!?<<< Пользователь с таким логином уже есть. >>>");
                                        data = mesToSend.getBytes();
                                        client.socket.Send(data);
                                    }

                                }
                                //сообщение для пользователей
                                else if (mes.getMesHeader() == "!>")
                                {
                                    Message mesToSend = new Message("!>" + client.login + ": " + mes.getMesBody());
                                    data = mesToSend.getBytes();
                                    foreach (ClientData targetClient in clients)
                                    {
                                        if(targetClient.online)targetClient.socket.Send(data);
                                    }

                                    CV.clentMessageSignal(client.login);
                                }

                            }
                        }
                    }
                    clients.Remove(oldUserData);
                }
            }
        }

        public void off()
        {
            isStarted = false;
        }

    }
}
