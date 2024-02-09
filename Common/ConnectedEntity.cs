using Common.Network;
using Common.Network.Message.high;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bunker_Server
{
    public class ConnectedEntity
    {
        TcpSender request;

        public ConnectedEntity(TcpClient tcp)
        {
            this.request = new TcpSender(tcp);
        }

        public bool Send(BunkerMessage message)
        {
            return request.Send(message.GetBytes());
        }

        public void ReadAsync(Action<BunkerMessage, NetworkStream> ExecuteRequestCB)
        {
            request.ReadAsync(ExecuteRequestCB);
        }

        public void Dispose()
        {
            request.Dispose();
        }
    }
}
