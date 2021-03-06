﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace SensorHub.Servers.Commands
{
    public class LSPressSetCmd : CommandBase<LSSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return " LSPressSet";
            }
        }

        public override void ExecuteCommand(LSSession session, BinaryRequestInfo requestInfo)
        {
            byte[] head = {0x40,0x08};
            byte[] body = requestInfo.Body;
            byte[] full = new byte[head.Length + body.Length];
            head.CopyTo(full, 0);
            body.CopyTo(full, head.Length);
            session.Send(full, 0, full.Length);
        }
    }
}
