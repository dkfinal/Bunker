using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Common.Network.Message.high;
using Common.Network.Message.low;

namespace Common.Network
{
    public class TcpSender
    {
        TcpClient tcp;
        bool isReading = false;
        public bool IsReading { get { return isReading; } }
        public TcpSender(TcpClient client)
        {
            tcp = client;
        }

        public bool Send(byte[] bytes)
        {
            try
            {
                tcp.GetStream().Write(bytes);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async void ReadAsync(Action<BunkerMessage, NetworkStream> ExecuteRequestCB)
        {
            isReading = true;
            TcpMessage message = new TcpMessage();
            try
            {
                await tcp.GetStream().ReadAsync(message.raw);
            }
            catch
            {
                isReading = false;
                return;
            }
            BunkerMessage bmsg = new BunkerMessage(message);
            ExecuteRequestCB(bmsg, tcp.GetStream());
            isReading = false;
        }

        public void Dispose()
        {
            tcp.Close();
            tcp.Dispose();
        }
    }
}
