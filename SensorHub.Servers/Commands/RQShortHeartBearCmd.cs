using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers.Commands
{
    /**
     * 【休眠模式(即设备主动上报数据模式)】登录建立连接
     * 设备先发送请求然后平台再向设备反馈
     **/
    public class RQShortHeartBeatCmd:CommandBase<RQSession,BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "RQShortConnectionHeartBeat";
            }
        }
        public override void ExecuteCommand(RQSession session, BinaryRequestInfo requestInfo)
        {
            byte[] rbody = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(rbody, 0, 11);
            }
            session.IP = rbody[11] + "." + rbody[12] + "." + rbody[13] + "." + rbody[14];

            byte[] header = { 0x7D, 0x81, 0x00, 0x10 };
            byte[] dtu = Encoding.ASCII.GetBytes(session.MacID);
            byte[] tail = { 0x7D };
            byte[] sBody = new byte[header.Length + dtu.Length + tail.Length];

            header.CopyTo(sBody, 0);
            dtu.CopyTo(sBody, header.Length);
            tail.CopyTo(sBody, header.Length + dtu.Length);

            session.Send(sBody, 0, sBody.Length);
        }

    }
}
