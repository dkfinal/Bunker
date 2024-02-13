using Bunker.Client;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunker.LoginScreen
{
    public partial class BunkerLoginForm : Form
    {
        BNKClient client;
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
            if (client != null)
                return;

            if (tbNickname.Text.Trim().Length == 0)
                return;

            client = new BNKClient();

            if(client.Connect(tbIP.Text))
            {
                bunkerMainForm = new BunkerForm(tbNickname.Text, ref client);
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
