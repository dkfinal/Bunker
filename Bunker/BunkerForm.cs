using Bunker.LoginScreen;
using Bunker_Server;
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
        ConnectedEntity tcpEntity;
        bool isReading = false;

        public BunkerForm(string nickname, ref TcpClient tcpClient)
        {
            InitializeComponent();

            lNickname.Text = nickname.Trim();
            tcpEntity = new ConnectedEntity(tcpClient);
            BunkerMessage msg = new BunkerMessage(RequestType.SET_NICKNAME, lNickname.Text);
            tcpEntity.Send(msg);
        }

        private void BunkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void worker_readasync_Tick(object sender, EventArgs e)
        {
            tcpEntity.ReadAsync(ExequteRequest);
        }

        private void ExequteRequest(BunkerMessage bmsg, NetworkStream stream)
        {
            switch (bmsg.GetRequestType())
            {
                case RequestType.KEEP_ALIVE:
                    break;
                default:
                    break;
            }
        }
    }
}
