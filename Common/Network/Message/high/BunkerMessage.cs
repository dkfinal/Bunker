using Common.Network.Message.low;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Network.Message.high
{
    public class BunkerMessage
    {
        const string delimiter = ";";
        string fullmessage;
        TcpMessage tcpmessage;

        public BunkerMessage(string type, string val)
        {
            fullmessage = type + delimiter + val;
            tcpmessage = new TcpMessage(fullmessage);
        }

        public BunkerMessage(string type)
        {
            fullmessage = type + delimiter;
            tcpmessage = new TcpMessage(fullmessage);
        }

        public BunkerMessage(TcpMessage msg)
        {
            tcpmessage = msg;
            fullmessage = tcpmessage.Unpack();
        }

        public string GetRequestType()
        {
            return fullmessage.Substring(0, fullmessage.IndexOf(delimiter));
        }

        public string GetRequestValue()
        {
            return fullmessage.Substring(fullmessage.IndexOf(delimiter) + 1);
        }

        public byte[] GetBytes()
        {
            return tcpmessage.raw;
        }
    }
}
