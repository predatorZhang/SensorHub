using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers.Commands
{
    /**
     * 【模式一：长连接模式(即召唤模式，应答模式)】数据召唤及回复
     * 平台先向设备发送数据上传请求。
     * 设备在收到指令后再向平台发送采集到的数据。
     **/
    public class RQActiveUploadCmd : CommandBase<RQSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "RQAciveUpload";
            }
        }

        public override void ExecuteCommand(RQSession session, BinaryRequestInfo requestInfo)
        {
            byte[] body = requestInfo.Body;

            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(body, 0, 11);
            }
            for (int i = 15; i < body.Length - 2; i += 4)
            {
                session.RQDATA.Add(BitConverter.ToSingle(new byte[] { body[i + 1], body[i], body[i + 3], body[i + 2] }, 0));
            }
        }
    }
}
