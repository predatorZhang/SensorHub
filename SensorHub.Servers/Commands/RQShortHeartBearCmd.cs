using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers.Commands
{
   
    public class RQShortHeartBeatCmd:CommandBase<RQSession,BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "RQShortConnectionHeartBeat";
            }
        }
    }


}
