using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace SensorHub.Servers.Commands
{
    public class SLGPRSResetCmd : CommandBase<SLSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "SLGPRSReset";
            }
        }

        public override void ExecuteCommand(SLSession session, BinaryRequestInfo requestInfo)
        {
            if (string.IsNullOrEmpty(session.SRCID) && string.IsNullOrEmpty(session.TAGID))
            {
                byte[] head = { 0xFF, 0x02, 0x0E, 0x61 };
                byte[] tail = { 0x03 };
                byte[] body = new byte[12];
                head.CopyTo(body, 0);
                Encoding.ASCII.GetBytes(session.SRCID).CopyTo(body, 4);
                Encoding.ASCII.GetBytes(session.TAGID).CopyTo(body, 10);
                tail.CopyTo(body, 11);
                session.Send(body, 0, body.Length);

            }
        }
    }
}
