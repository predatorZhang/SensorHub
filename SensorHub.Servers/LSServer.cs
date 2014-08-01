using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SensorHub.Servers.Commands;
namespace SensorHub.Servers
{
    public class LSServer : AppServer<LSSession, BinaryRequestInfo>
    {
        public LSServer()
            : base(new DefaultReceiveFilterFactory<LSFilter, BinaryRequestInfo>())
        { 

        }

    }
}
