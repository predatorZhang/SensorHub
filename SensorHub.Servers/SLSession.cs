using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
namespace SensorHub.Servers
{
    public class SLSession: AppSession<SLSession, BinaryRequestInfo>
    {
        private string macID;

        private string srcId;

        private string tagId;

        private string productCompany;

        private string sensorType;

        public string SensorType
        {
            get { return sensorType; }
            set { sensorType = value; }
        }

        public string ProductCompany
        {
            get { return productCompany; }
            set { productCompany = value; }
        }

        public string MacID
        {
            get { return macID; }
            set { macID = value; }
        }

        public string SRCID
        {
            get { return srcId; }
            set { srcId = value; }
        }

        public string TAGID
        {
            get { return tagId; }
            set { tagId = value; }
        }
    }
}
