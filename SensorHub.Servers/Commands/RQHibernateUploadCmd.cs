using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers.Commands
{
   
    public class RQHibernateUploadCmd:CommandBase<RQSession,BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "RQHibernateUpload";
            }
        }

        /*
        public override void ExecuteCommand(AppSession session, BinaryRequestInfo requestInfo)
        {
           // session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
        }
         * */
    }


}
