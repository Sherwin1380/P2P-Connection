using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientWindow clientform = new ClientWindow();
            clientform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerWindow serverform = new ServerWindow();
            serverform.Show();
        }
    }
}
