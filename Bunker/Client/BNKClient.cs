using Common;
using Common.Network.Message;
using Common.Network.Message.high;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Client
{
    public class BNKClient
    {
        int port = 29500;
        ConnectedEntity tcpEntity;

        public BNKClient()
        {

        }

        public bool Connect(string tbIP)
        {
            IPAddress ip;
            try
            {
                ip = IPAddress.Parse(tbIP);
            }
            catch
            {
                return false;
            }
            IPEndPoint iep = new IPEndPoint(ip, port);

            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(iep);
            }
            catch
            {
                tcpClient.Close();
                tcpClient.Dispose();
                return false;
            }

            if (tcpClient.Connected)
            {
                tcpEntity = new ConnectedEntity(tcpClient);
                return true;
            }
            return false;
        }

        //Use RequestType to set type of message
        public bool Send(string type, string msg)
        {
            BunkerMessage bnkmsg = new BunkerMessage(type, msg);
            tcpEntity.Send(bnkmsg);
            return false;
        }

        public void ReadAsync(Action<BunkerMessage, NetworkStream> ExecuteRequest)
        {
            tcpEntity.ReadAsync(ExecuteRequest);
        }
    }
}
