using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.Http.Headers;

namespace TCP
{
    public partial class Server : Form
    {
        public Server()
        {
            public Server()
            {
                InitializeComponent();
                Control.CheckForIllegalCrossThreadCalls = false;
                Connect();
            }

            IPEndPoint ipe;
            Socket client;
            TcpListener tcplisten;

        }
        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send(client);
        }
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Any, 9999);
            tcplisten = new TcpListener(ipe);

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    tcplisten.Start();
                    client = tcplisten.AcceptSocket();
                    Thread rec = new Thread(Receive);
                    rec.IsBackground = true;
                    rec.Start(client);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        void Send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(tbMessage.Text);
            client.Send(data);
            AddMessage(tbMessage.Text);
            tbMessage.Clear();
        }

        void Receive(Object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                AddMessage(s);
            }
        }
        void AddMessage(string mess)
        {
            lvMess.Items.Add(mess);
        }

    }
}
