using System.Data.Common;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using BNKDatabase;
using Bunker_Server.Server;
using Common.Network.Message;
using Common.Network.Message.high;

namespace Bunker_Server
{
    public partial class BunkerServerForm : Form
    {
        BNKCore core;

        public BunkerServerForm()
        {
            core = new BNKCore();
            InitializeComponent();

            var storylst = core.GetStoryList();
            foreach (var story in storylst)
            {
                CMBStories.Items.Add(story);
            }
            if (CMBStories.Items.Count > 0)
            {
                CMBStories.SelectedItem = CMBStories.Items[0];
            }
        }

        private void worker_listener_Tick(object sender, EventArgs e)
        {
            lClientAmount.Text = core.ManageConnection().ToString();
        }

        private void worker_keepalive_Tick(object sender, EventArgs e)
        {
            lClientAmount.Text = core.KeepAliveClients().ToString();
        }

        private void worker_readasync_Tick(object sender, EventArgs e)
        {
            core.ReadAsyncClients(ExecuteRequest);
        }

        //TO-DO relocate this method.
        private void ExecuteRequest(BunkerMessage bmsg, NetworkStream stream)
        {
            switch (bmsg.GetRequestType())
            {
                case TcpRequestType.SET_NICKNAME:
                    lbLogs.Items.Add(bmsg.GetRequestValue() + " connected");
                    break;
                case TcpRequestType.KEEP_ALIVE:
                    break;
                default:
                    break;
            }
        }

        private void CMBStories_SelectedIndexChanged(object sender, EventArgs e)
        {
            core.CreateStory(CMBStories.SelectedIndex);
            lbLogs.Items.Add("Minimum players set to " + core.GetStoryMinClients().ToString());
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            //lStatus.Text = core.GameStart();
        }

        private void bRestart_Click(object sender, EventArgs e)
        {

        }
    }
}
