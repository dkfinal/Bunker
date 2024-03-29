﻿using Bunker.Client;
using Bunker.LoginScreen;
using Common.Network.Message;
using Common.Network.Message.high;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunker
{
    public partial class BunkerForm : Form
    {
        BNKClient client;
        bool isReading = false;

        public BunkerForm(string nickname, ref BNKClient client)
        {
            InitializeComponent();
            lNickname.Text = nickname.Trim();
            this.client = client;
            client.Send(TcpRequestType.SET_NICKNAME, lNickname.Text);
        }

        private void BunkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void worker_readasync_Tick(object sender, EventArgs e)
        {
            client.ReadAsync(ExecuteRequest);
        }

        //TO-DO reorganize executioner
        private void ExecuteRequest(BunkerMessage bmsg, NetworkStream stream)
        {
            switch (bmsg.GetRequestType())
            {
                case TcpRequestType.KEEP_ALIVE:
                    break;
                default:
                    break;
            }
        }
    }
}
