using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_client
{
    public partial class Form1 : Form
    {

        TextBox ipInput, portInput, loginInput, onlineClients, chat, mesInput, passwordInput;
        Button connectButton, sendButton;
        Client client;

        public Form1()
        {
            InitializeComponent();

            //ввод ip
            ipInput = new TextBox();
            ipInput.Location=new Point(130, 25);
            ipInput.Size=new Size{ Width= 100, Height= 25};

            Label ipLabel = new Label();
            ipLabel.Location = new Point(25, 25);
            ipLabel.Text = "Введите ip сервера:";
            this.Controls.Add(ipLabel);

            this.Controls.Add(ipInput);

            //ввод порта
            portInput = new TextBox();
            portInput.Location = new Point(130, 50);
            portInput.Size = new Size { Width = 100, Height = 25 };

            Label portLabel = new Label();
            portLabel.Location = new Point(25, 50);
            portLabel.Text = "Введите порт:";
            this.Controls.Add(portLabel);

            this.Controls.Add(portInput);


            //ввод логина
            loginInput = new TextBox();
            loginInput.Location = new Point(130, 75);
            loginInput.Size = new Size { Width = 100, Height = 25 };

            Label loginLabel = new Label();
            loginLabel.Location = new Point(25, 75);
            loginLabel.Text = "Введите логин:";
            this.Controls.Add(loginLabel);

            this.Controls.Add(loginInput);

            //ввод пароля
            passwordInput = new TextBox();
            passwordInput.Location = new Point(130, 100);
            passwordInput.Size = new Size { Width = 100, Height = 25 };

            Label passwordLabel = new Label();
            passwordLabel.Location = new Point(25, 100);
            passwordLabel.Text = "Введите пароль:";
            this.Controls.Add(passwordLabel);

            this.Controls.Add(passwordInput);

            //кнопка соединения
            connectButton = new Button();
            connectButton.Location = new Point(85, 125);
            connectButton.Size = new Size { Width = 100, Height = 22 };
            connectButton.Text = "Подключиться";
            connectButton.Click += startSession;
            this.Controls.Add(connectButton);


            //список онлайн клиентов
            onlineClients = new TextBox();
            onlineClients.Location = new Point(25, 180);
            onlineClients.Size = new Size { Width = 150, Height = 200 };
            onlineClients.Multiline = true;
            onlineClients.ReadOnly = true;
            onlineClients.ScrollBars = ScrollBars.Vertical;

            Label onlineLabel = new Label();
            onlineLabel.Location = new Point(25, 150);
            onlineLabel.Text = "Сейчас в сети:";
            this.Controls.Add(onlineLabel);

            this.Controls.Add(onlineClients);

            //чат
            chat = new TextBox();
            chat.Location = new Point(350, 25);
            chat.Size = new Size { Width = 300, Height = 350 };
            chat.Multiline = true;
            chat.ReadOnly = true;
            chat.ScrollBars = ScrollBars.Vertical;

            this.Controls.Add(chat);

            //ввод сообщения
            mesInput = new TextBox();
            mesInput.Location = new Point(350, 400);
            mesInput.Size = new Size { Width = 190, Height = 30 };
            mesInput.Multiline = true;
            mesInput.ScrollBars = ScrollBars.Vertical;

            this.Controls.Add(mesInput);

            //кнопка отправки
            sendButton = new Button();
            sendButton.Location = new Point(550, 400);
            sendButton.Size = new Size { Width = 100, Height = 30 };
            sendButton.Text = "Отправить";
            sendButton.Click += sendMes;
            this.Controls.Add(sendButton);

            client = new Client();
            ipInput.Text = "127.0.0.1";
            portInput.Text = "3333";

        }

        private void mesController()
        {
            while (true)
            {
                string str = "";
                str= client.getMessage();
                if (str != "")
                {
                    string mesHeader = str.Substring(0, 2);
                    string mesBody = str.Substring(2, str.Length - 2);

                    //Сообщение для вывода
                    if (mesHeader == "!>")
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            chat.AppendText(mesBody);
                            chat.AppendText(Environment.NewLine);
                        });
                    }
                    //Список онлайн пользователей
                    else if (mesHeader == "!$")
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            onlineClients.Text=mesBody;
                        });
                    }
                    //ошибка авторизации
                    else if (mesHeader == "!?")
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            loginInput.Enabled = true;
                            passwordInput.Enabled = true;
                            connectButton.Enabled = true;
                            chat.AppendText(mesBody);
                            chat.AppendText(Environment.NewLine);
                        });
                    }
                }
            }
        }

        private void startSession(object sender, EventArgs e)
        {
            string ip = ipInput.Text;
            int port = int.Parse(portInput.Text);
            string login = loginInput.Text;
            string password = passwordInput.Text;

            if (ipInput.Enabled) {
                client.connect(ip, port);
                Thread mesPrinterThread = new Thread(mesController);
                mesPrinterThread.Start();
            }

            //отправка сообщения об авторизации
            client.sendMessage("!@", login + "@" + password);

            ipInput.Enabled = false;
            portInput.Enabled = false;
            loginInput.Enabled = false;
            passwordInput.Enabled = false;
            connectButton.Enabled = false;

        }

        private void sendMes(object sender, EventArgs e)
        {
            string mes = mesInput.Text;
            client.sendMessage("!>", mes);
            mesInput.Text = "";
        }

    }
}
