using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunker.LoginScreen
{
    public partial class BunkerLoginForm : Form
    {
        int port = 29500;
        TcpClient tcpClient;
        BunkerForm bunkerMainForm;


        public BunkerLoginForm()
        {
            InitializeComponent();
        }

        private void BunkerLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (tcpClient != null)
                return;

            if(tbNickname.Text.Trim().Length == 0)
                return;


            IPAddress ip;
            try {
                ip = IPAddress.Parse(tbIP.Text);
            }
            catch
            {
                return;
            }
            IPEndPoint iep = new IPEndPoint(ip, port);

            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(iep);
            }
            catch
            {
                tcpClient.Close();
                tcpClient.Dispose();
                return;
            }

            if(tcpClient.Connected)
            {
                bunkerMainForm = new BunkerForm(tbNickname.Text, ref tcpClient);
                bunkerMainForm.FormClosed += CloseThisForm;
                bunkerMainForm.Show();

                this.Hide();
            }
        }

        void CloseThisForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
