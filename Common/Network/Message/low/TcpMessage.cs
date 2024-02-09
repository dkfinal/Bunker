using System.Dynamic;
using System.Text;

namespace Common.Network.Message.low
{
    public class TcpMessage
    {
        //tcp message delimiter
        const string delimiter = "|END|";
        //raw bytes of tcp request
        public byte[] raw { get; }

        public TcpMessage()
        {
            //incoming message must not be any longer than 128 bytes in UTF-8
            raw = new byte[128];
        }

        //preparing bytes for transition via tcp
        public TcpMessage(string message)
        {
            raw = Encoding.UTF8.GetBytes(message + delimiter);
        }

        //get the message from raw bytes
        private string Get()
        {
            if (raw == null)
                return "ERROR; NULL MESSAGE";   //TODO: error class

            return Encoding.UTF8.GetString(raw).Substring(0, Encoding.UTF8.GetString(raw).IndexOf(delimiter));
        }

        public string Unpack()
        {
            return Get();
        }
    }
}
