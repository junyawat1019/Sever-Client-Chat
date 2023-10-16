using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeverClientChat
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader str;
        private StreamWriter stw;
        public string receive;
        public string sendtext;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textIPServer.Text = address.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStartSever_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(textPortServer.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ip_end =  new IPEndPoint(IPAddress.Parse(textIPClient.Text),int.Parse(textPortClient.Text));
            try
            {
                client.Connect(ip_end);
                if (client.Connected)
                {
                    textShowMessage.AppendText("Connect Complete \n");
                    str = new StreamReader(client.GetStream());
                    stw = new StreamWriter(client.GetStream());
                    stw.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textsend.Text))
            {
                sendtext = textsend.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textsend.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = str.ReadLine();
                    this.textShowMessage.Invoke(new MethodInvoker(delegate ()
                    {
                        this.textShowMessage.AppendText("You : " + receive + "\n");
                    }));
                    receive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(sendtext);
                this.textShowMessage.Invoke(new MethodInvoker(delegate ()
                {
                    this.textShowMessage.AppendText("Me : " + sendtext + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Error");
            }
            backgroundWorker2.CancelAsync();
        }
    }
}
