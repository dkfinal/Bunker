using Common.Network.Message.high;
using Common.Network.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bunker_Server.Server
{
    public class BNKServer
    {
        int port = 29500;
        TcpListener listener;
        IPEndPoint iep;
        List<ConnectedEntity> clients = new List<ConnectedEntity>();

        public BNKServer()
        {
            iep = new IPEndPoint(IPAddress.Any, port);
            listener = new TcpListener(iep);
            listener.Start();
        }

        public int ListenConnections()
        {
            if (listener.Pending())
            {
                clients.Add(new ConnectedEntity(listener.AcceptTcpClient()));
            }
            return clients.Count;
        }

        public int KeepAlive()
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (!clients[i].Send(new BunkerMessage(RequestType.KEEP_ALIVE)))
                {
                    clients[i].Dispose();
                    clients.RemoveAt(i);
                }
            }
            return clients.Count;
        }
        public void ReadAsync(Action<BunkerMessage, NetworkStream> ExecuteRequest)
        {
            foreach (var client in clients)
            {
                client.ReadAsync(ExecuteRequest);
            }
        }
    }
}
