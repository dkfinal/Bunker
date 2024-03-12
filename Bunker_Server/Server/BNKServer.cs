using Common.Network.Message.high;
using Common.Network.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Common;
using Bunker_Server.Core;

namespace Bunker_Server.Server
{
    public class BNKServer
    {
        int port = 29500;
        TcpListener listener;
        IPEndPoint iep;
        List<ConnectedEntity> clients;
        bool isListening;

        public BNKServer()
        {
            clients = new List<ConnectedEntity>();
            iep = new IPEndPoint(IPAddress.Any, port);
            listener = new TcpListener(iep);
            listener.Start();
            isListening = true;
        }

        public int ListenConnections()
        {
            if (isListening)
            {
                if (listener.Pending())
                {
                    clients.Add(new ConnectedEntity(listener.AcceptTcpClient()));
                }
            }
            return clients.Count;
        }

        public int KeepAlive()
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (!clients[i].Send(new BunkerMessage(TcpRequestType.KEEP_ALIVE)))
                {
                    clients[i].Dispose();
                    clients.RemoveAt(i);
                }
            }
            return clients.Count;
        }

        public int GetClientsAmount()
        {
            return clients.Count;
        }

        public void Notifyer(string gameStatus)
        {
            switch (gameStatus)
            {
                case GameStatus.STATUS_IDLE:
                    isListening = true;
                    break;
                case GameStatus.STATUS_VOTE:
                    isListening = false;
                    break;
                default:
                    break;
            }
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
