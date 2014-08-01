using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers.Commands
{
    /**
     * 【模式二：休眠模式(即设备主动上报数据模式)】设备主动上报数据及平台回复
     * 设备先把采集结果主动上报到平台
     * 平台在收到结果后再把接收结果反馈给设备
     **/
    public class RQHibernateUploadCmd:CommandBase<RQSession,BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "RQHibernateUpload";
            }
        }

        public override void ExecuteCommand(RQSession session, BinaryRequestInfo requestInfo)
        {
            byte[] rbody = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(rbody, 0, 11);
            }
            for (int i = 18; i < rbody.Length - 2; i += 4)
            {
                session.RQDATA.Add(BitConverter.ToSingle(new byte[] { rbody[i + 1], rbody[i], rbody[i + 3], rbody[i + 2] }, 0));
            }

            byte[] header = { 0x7D, 0x89, 0x00, 0x10 };
            byte[] dtu = Encoding.ASCII.GetBytes(session.MacID);
            byte[] tail = { 0x7D, 0x01, 0x10, 0x00, 0x00, 0x00, 0x26, 0xC1, 0xCA };
            byte[] sbody = new byte[header.Length + dtu.Length + tail.Length];

            header.CopyTo(sbody, 0);
            dtu.CopyTo(sbody, header.Length);
            tail.CopyTo(sbody, header.Length + dtu.Length);

            session.Send(sbody, 0, sbody.Length);
        }
    }


}
