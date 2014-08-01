using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace SensorHub.Servers
{
    public class RQSession : AppSession<RQSession, BinaryRequestInfo>
    {
        private string macID;

        private string productCompany;

        private string sensorType;

        private string ip;

        private List<double> rqData;

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

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }

        public List<double> RQDATA
        {
            get { return rqData; }
            set { rqData = value; }
        }

    }
}
