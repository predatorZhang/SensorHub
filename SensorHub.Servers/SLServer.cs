using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SensorHub.Servers.Commands;
namespace SensorHub.Servers
{
    public class SLServer : AppServer<SLSession, BinaryRequestInfo>
    {
        public SLServer()
            :base(new DefaultReceiveFilterFactory<SLFilter, BinaryRequestInfo>())
        { 
        }
    }
}
