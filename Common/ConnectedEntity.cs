using Common.Network;
using Common.Network.Message.high;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ConnectedEntity
    {
        TcpSender request;
        PlayerCard playerCard;

        public ConnectedEntity(TcpClient tcp)
        {
            request = new TcpSender(tcp);
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
