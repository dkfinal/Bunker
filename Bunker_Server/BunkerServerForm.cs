using System.Net;
using System.Net.Sockets;
using System.Text;
using Common.Network.Message;
using Common.Network.Message.high;

namespace Bunker_Server
{
    public partial class BunkerServerForm : Form
    {
        int port = 29500;
        TcpListener listener;
        IPEndPoint iep;
        List<ConnectedEntity> clients = new List<ConnectedEntity>();

        public BunkerServerForm()
        {
            iep = new IPEndPoint(IPAddress.Any, port);
            listener = new TcpListener(iep);
            listener.Start();
            InitializeComponent();
        }

        void ExecuteRequest(BunkerMessage bmsg, NetworkStream stream)
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
        private void worker_listener_Tick(object sender, EventArgs e)
        {
            if (listener.Pending())
            {
                clients.Add(new ConnectedEntity(listener.AcceptTcpClient()));
                lClientAmount.Text = clients.Count.ToString();
            }
        }

        private void worker_keepalive_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (!clients[i].Send(new BunkerMessage(RequestType.KEEP_ALIVE)))
                {
                    clients[i].Dispose();
                    clients.RemoveAt(i);
                    lClientAmount.Text = clients.Count.ToString();
                }
            }
        }

        private void worker_readasync_Tick(object sender, EventArgs e)
        {
            foreach (var client in clients)
            {
                client.ReadAsync(ExecuteRequest);
            }
        }
    }
}
