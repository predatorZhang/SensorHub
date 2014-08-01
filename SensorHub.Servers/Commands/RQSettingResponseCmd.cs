using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers.Commands
{
    /**
     * 【模式三：平台写设备远程配置】设备端回复
     * 平台先向设备发送配置信息
     * 设备在收到配置信息后再向平台反馈结果
     * */
    public class RQSettingResponseCmd:CommandBase<RQSession,BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "RQSettingResponse";
            }
        }

        public override void ExecuteCommand(RQSession session, BinaryRequestInfo requestInfo)
        {
            byte[] body = requestInfo.Body;
            if (string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(body, 0, 11);
            }
        }
    }


}
