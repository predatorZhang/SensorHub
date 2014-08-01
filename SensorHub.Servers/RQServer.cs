using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SensorHub.Servers.Commands;
namespace SensorHub.Servers
{
    public class RQServer : AppServer<RQSession, BinaryRequestInfo>
    {
        public RQServer()
            : base(new DefaultReceiveFilterFactory<RQFilter, BinaryRequestInfo>())
        { 
        }
    }
}
