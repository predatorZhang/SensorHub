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
    public class LSReceivePressCmd : CommandBase<LSSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "LSReceivePress";
            }
        }

        public override void ExecuteCommand(LSSession session, BinaryRequestInfo requestInfo)
        {
            byte[] body = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(body, 5, 6);
            }

            DjPressInfo press = new DjPressInfo();
            press.DEVID = session.MacID;
            StringBuilder sb = new StringBuilder();
            for (int i = 25; i < body.Length - 5; i += 9)
            {
                sb.Append(BitConverter.ToSingle(new byte[] { body[i + 1],
                    body[i + 2], body[i + 3], body[i + 4],
                    body[i + 5], body[i + 6], body[i + 7], 
                    body[i + 8] }, 0).ToString()).Append(",");
            }
            press.PRESSDATA = sb.Remove(sb.Length - 1, 1).ToString();
            press.PRESSPOWER = Convert.ToDouble(body[body.Length-5]).ToString();
            press.SENSORPOWER=Convert.ToDouble(body[body.Length-4]).ToString();
            press.DATATIME = Convert.ToInt16(body[24]).ToString() + "-" + Convert.ToInt16(body[23]).ToString() + "-" + Convert.ToInt16(body[22]).ToString() + " " + Convert.ToInt16(body[21]) + ":" + Convert.ToInt16(body[20]).ToString() + ":00";
            press.RECORDTIME = DateTime.Now.ToShortDateString();
            new DjPress().insert(press);
        }
    }
}
