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
    public class SLUploadCmd : CommandBase<SLSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "SLUpload";
            }
        }

        public override void ExecuteCommand(SLSession session, BinaryRequestInfo requestInfo)
        {
            byte[] rbody = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID = Encoding.ASCII.GetString(rbody, 1, 6);
                session.SRCID = session.MacID;
                session.TAGID = Encoding.ASCII.GetString(rbody, 7, 6);
            }

            SlNoiseInfo noise = new SlNoiseInfo();
            noise.DEVID = session.MacID;
            noise.LOOSEDATA = BitConverter.ToSingle(new byte[] { rbody[31], rbody[30] }, 0).ToString();
            noise.DENSEDATA = BitConverter.ToSingle(new byte[] { rbody[34], rbody[33] }, 0).ToString();
            noise.SENSORPOWER = Convert.ToDouble(rbody[35]).ToString();
            noise.DATATIME = Convert.ToInt16(rbody[19]).ToString() + "-" + Convert.ToInt16(rbody[18]).ToString() + "-" + Convert.ToInt16(rbody[17]).ToString() + " " + Convert.ToInt16(rbody[16]) + ":" + Convert.ToInt16(rbody[15]).ToString() + ":00";
            noise.RECORDTIME = DateTime.Now.ToShortDateString();
            new SlNoise().insert(noise);
        }
    }
}
