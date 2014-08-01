using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketBase.Command;
using SensorHub.Model;
using SensorHub.BLL;

namespace SensorHub.Servers.Commands
{
    public class LSReciveNoiseCmd : CommandBase<LSSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "LSReciveNoise";
            }
        }

        public override void ExecuteCommand(LSSession session, BinaryRequestInfo requestInfo)
        {
            byte[] body = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(body, 6, 6);
            }
            StringBuilder loose = new StringBuilder();
            StringBuilder dense = new StringBuilder();
            DjNoiseInfo noise = new DjNoiseInfo();
            noise.DEVID = session.MacID;
            for (int i = 29; i < 29 + (body.Length - 34) / 2; i += 2)
            {
                loose.Append(BitConverter.ToSingle(new byte[] { body[i + 1], body[i] }, 0).ToString()).Append(",");
            }
            noise.LOOSEDATA = loose.Remove(loose.Length - 1, 1).ToString();
            noise.DATATIME = Convert.ToInt16(body[28]).ToString() + "-" + Convert.ToInt16(body[27]).ToString() + "-" + Convert.ToInt16(body[26]).ToString() + " " + Convert.ToInt16(body[25]) + ":" + Convert.ToInt16(body[24]).ToString() + ":00";
            for (int i = 13 + body.Length / 2; i < body.Length - 4; i += 2)
            {
                dense.Append(BitConverter.ToSingle(new byte[] { body[i + 1], body[i] }, 0).ToString()).Append(",");
            }
            noise.DENSEDATA = dense.Remove(dense.Length - 1, 1).ToString();
            noise.RECORDTIME = DateTime.Now.ToShortDateString();

            new DjNoise().insert(noise);
        }
    }
}
