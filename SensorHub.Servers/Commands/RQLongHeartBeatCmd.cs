using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers.Commands
{
    /**
     * 【模式一：长连接模式(即召唤模式，应答模式)】登录建立连接
     * 设备先向平台发送连接请求
     * 平台在收到连接请求后再向设备发送连接结果。
     * */
    public class RQLongHeartBeatCmd : CommandBase<RQSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "7D-01-00-16";
                //return "RQLongConnectionHeartBeat";
            }
        }

        public override void ExecuteCommand(RQSession session, BinaryRequestInfo requestInfo)
        {
            Console.WriteLine("进入这个操作了");
            byte[] rBody = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(rBody, 0, 11);
            }
            session.IP = rBody[11] + "." + rBody[12] + "." + rBody[13] + "." + rBody[14];

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
