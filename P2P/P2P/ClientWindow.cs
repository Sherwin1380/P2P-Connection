using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace P2P
{
    public partial class ClientWindow : Form
    {
        public Socket client;
        public string j;
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientconnect();
            
        }

        private void clientconnect()
        { 
         try {
                string ipaddress = iptextbox.Text;
                int portno = Int32.Parse(porttextbox.Text);
                IPAddress ip = IPAddress.Parse(ipaddress);
                IPEndPoint ipEndPoint = new IPEndPoint(ip, portno);
                client = new Socket(AddressFamily.InterNetwork,
        SocketType.Stream, ProtocolType.Tcp);
                client.Connect(ipEndPoint);
                Statustextbox.Text = "ONLINE";
                Statustextbox.BackColor = Color.Green;
                Statustextbox.ForeColor = Color.White;
                selectfilebutton.Visible = true;
                okbutton.Visible = false;
                iptextbox.Enabled = false;
                porttextbox.Enabled = false;
            }
            catch 
            {
                Statustextbox.BackColor = Color.Red;
                Statustextbox.ForeColor = Color.White;
                Statustextbox.Text = "OFFLINE";
            }
        }
        private void sendbutton_Click(object sender, EventArgs e)
        {
            
            client.SendFile(j);
            client.Close();
            MessageBox.Show("File has been sent");
            clientconnect();
        }

        private void ClientWindow_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                 openFileDialog1.ShowDialog();
                j = openFileDialog1.FileName;
                if(j.Equals("") || j.Equals(null))
                { }
                else
                sendbutton.Visible = true;
            }
            catch
            { 
            
            }
            
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
