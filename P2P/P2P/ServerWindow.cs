using Microsoft.VisualBasic;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P
{
    public partial class ServerWindow : Form
    {
        string s;
        int h;
        static int x = 0;
        public FileStream fileStream;
        public string path;
        public ServerWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = Interaction.InputBox("What is the maximum file size to be recieved?", "File Input Size", "100");
            try
            {
                h = Int32.Parse(s);
                if (h <= 0)
                    h = 100;
                setvisibility();
            }
            catch
            {
                h = 100;
                setvisibility();
            }
            Thread thread = new Thread(new ThreadStart(createserver));
            thread.Start();
        }

        private void createserver()
        {
            try {
                //change IPAddress here for local machine
                IPAddress IP = IPAddress.Parse("192.168.1.143");
                var listener = new TcpListener(IP, 1133);
                listener.Start();
                TcpClient tcpClient= listener.AcceptTcpClient();
                while (tcpClient.Connected)
                {
                    x++;
                    Console.WriteLine("connected");
                     path = @"D:\\MyTest" + x + ".txt";
                    fileStream = File.Create(path);
                    Invoke(new Action(() =>
                    {
                        closeserverbutton.Enabled = true;
                    }));
                    NetworkStream stream = tcpClient.GetStream();
                    while (!stream.DataAvailable)
                    {
                        stream = tcpClient.GetStream();
                    }
                    try
                    {
                        stream.CopyTo(fileStream);
                        fileStream.Close();
                        tcpClient.Close();
                        stream.Close();
                        listener.Stop();
                        Console.WriteLine("File Recieved");
                    }
                    catch
                    { } 

                    }
                createserver();

            }
            catch
            {
                Console.WriteLine("done");
            }
        }


        public void setvisibility()
        {
            Backbutton.Visible = false;
            serverrunlabel.Visible = true;
            filetransferlabel.Visible = true;
            closeserverbutton.Visible = true;
        }


        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeserverbutton_Click(object sender, EventArgs e)
        {
            try
            {
                
                fileStream.Close();
                File.Delete(path);
                x--;
                closeserverbutton.Enabled = false;
                this.Close();
                MessageBox.Show("The Number of Files Recieved : " + x);
            }
            catch
            {
                closeserverbutton.Enabled = false;
                this.Close();
                MessageBox.Show("The Number of Files Recieved : " + x);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (closeserverbutton.Enabled)
            {
                e.Cancel = true;
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Server has not been closed yet");
                }));
                
            }
        }
            }
    }


