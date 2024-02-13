using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using Bunker_Server.Server;
using Common.Network.Message;
using Common.Network.Message.high;

namespace Bunker_Server
{
    public partial class BunkerServerForm : Form
    {
        BNKServer server;

        public BunkerServerForm()
        {
            server = new BNKServer();
            InitializeComponent();
        }
        
        private void worker_listener_Tick(object sender, EventArgs e)
        {
            lClientAmount.Text = server.ListenConnections().ToString();
        }

        private void worker_keepalive_Tick(object sender, EventArgs e)
        {
            lClientAmount.Text = server.KeepAlive().ToString();
        }

        private void worker_readasync_Tick(object sender, EventArgs e)
        {
            server.ReadAsync(ExecuteRequest);
        }

        //TO-DO reorganize executioner
        private void ExecuteRequest(BunkerMessage bmsg, NetworkStream stream)
        {
            switch (bmsg.GetRequestType())
            {
                case RequestType.SET_NICKNAME:
                    lbNetLogs.Items.Add(bmsg.GetRequestValue() + " connected");
                    break;
                case RequestType.KEEP_ALIVE:
                    break;
                default:
                    break;
            }
        }
    }
}
