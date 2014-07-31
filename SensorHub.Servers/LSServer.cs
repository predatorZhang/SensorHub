using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers
{
    public class LSServer : AppServer<LSSession, BinaryRequestInfo>
    {
        public LSServer()
        { 

        }

    }
}
