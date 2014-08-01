using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using SensorHub.Model;
using SensorHub.BLL;

namespace SensorHub.Servers.Commands
{
    public class LSReciveFlowCmd : CommandBase<LSSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "LSReciveFlow";
            }
        }

        public override void ExecuteCommand(LSSession session, BinaryRequestInfo requestInfo)
        {
            byte[] body = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(body, 5, 6);
            }
            DjFlowInfo flow = new DjFlowInfo();
            flow.DEVID = session.MacID;
            StringBuilder sb = new StringBuilder();
            for (int i = 25; i < 25 + body.Length - 42; i += 4)
            {
                sb.Append(BitConverter.ToSingle(new byte[] { body[i + 1], body[i], body[i + 3], body[i + 2] }, 0).ToString()).Append(",");
            }
            flow.INSDATA = sb.Remove(sb.Length - 1, 1).ToString();
            flow.NEGDATA = BitConverter.ToSingle(new byte[] { body[5 + body.Length / 2], body[4 + body.Length / 2], body[7 + body.Length / 2], body[6 + body.Length / 2] }, 0).ToString();
            flow.POSDATA = BitConverter.ToSingle(new byte[] { body[9 + body.Length / 2], body[8 + body.Length / 2], body[11 + body.Length / 2], body[10 + body.Length / 2] }, 0).ToString();
            flow.NEGDATA = BitConverter.ToSingle(new byte[] { body[13 + body.Length / 2], body[12 + body.Length / 2], body[15 + body.Length / 2], body[14 + body.Length / 2] }, 0).ToString();
            flow.DATATIME = Convert.ToInt16(body[29]).ToString() + "-" + Convert.ToInt16(body[28]).ToString() + "-" + Convert.ToInt16(body[27]).ToString() + " " + Convert.ToInt16(body[26]) + ":" + Convert.ToInt16(body[25]).ToString() + ":00";
            flow.RECORDTIME = DateTime.Now.ToShortDateString();
            new DjFlow().insert(flow);
        }
    }
}
