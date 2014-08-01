using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using SensorHub.Model;

namespace SensorHub.Servers.Commands
{
    public class LSReceiveLiquidCmd : CommandBase<LSSession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "LSReceiveLiquid";
            }
        }

        public override void ExecuteCommand(LSSession session, BinaryRequestInfo requestInfo)
        {
            byte[] body = requestInfo.Body;
            if (!string.IsNullOrEmpty(session.MacID))
            {
                session.MacID=Encoding.ASCII.GetString(byte,5,6);
            }
            DjLiquidInfo liquid=new DjLiquidInfo ();
            liquid.DEVID=session.MacID;
            StringBuilder sb=new StringBuilder();
            for(int i=25;i<body.Length-5;i+=4){
                sb.Append(BitConverter.ToSingle(new byte[]{body[i],body[i+1],body[i+2],body[i+3]},0).ToString()).Append(",");
            }
            liquid.LIQUIDDATA = sb.Remove(sb.Length-1,1).ToString();
            liquid.LIQUIDPOWER=Convert.ToDouble(body[body.Length-4]).ToString();
            liquid.SENSORPOWER=Convert.ToDouble(body[body.Length-3]).ToString();
            liquid.DATATIME= Convert.ToInt16(body[24]).ToString() + "-" + Convert.ToInt16(body[23]).ToString() + "-" + Convert.ToInt16(body[22]).ToString() + " " + Convert.ToInt16(body[21]) + ":" + Convert.ToInt16(body[20]).ToString() + ":00";
            liquid.RECORDTIME=DateTime.Now.ToShortDateString();
        }
    }
}
