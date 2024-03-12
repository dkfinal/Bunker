using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Network.Message
{
    public static class TcpRequestType
    {
        public const string
            SET_NICKNAME = "request_nickname",
            KEEP_ALIVE = "request_keepalive",
            USE_SKILL1 = "request_skill1",
            USE_SKILL2 = "request_skill2";

    }
}
