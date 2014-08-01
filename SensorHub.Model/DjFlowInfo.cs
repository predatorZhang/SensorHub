using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorHub.Model
{
    public class DjFlowInfo
    {
        private long dbId;
        //设备ID
        private string devId;
        private string insData;
        private string netData;
        private string posData;
        private string negData;
        private string flowPower;
        private string sensorPower;
        private string dataTime;
        private string recordTime;

        //数据库主键
        public long DBID
        {
            get { return dbId; }
            set { dbId = value; }
        }

        //设备ID
        public string DEVID
        {
            get { return devId; }
            set { devId = value; }
        }

        //瞬时流量
        public string INSDATA
        {
            get { return insData; }
            set { insData = value; }
        }

        //净累计流量
        public string NETDATA
        {
            get { return netData; }
            set { netData = value; }
        }

        //正累计流量
        public string POSDATA
        {
            get { return posData; }
            set { posData = value; }
        }

        //负累计流量
        public string NEGDATA
        {
            get { return negData; }
            set { negData = value; }
        }

        //流量计电量
        public string FLOWPOWER
        {
            get { return flowPower; }
            set { flowPower = value; }
        }

        //记录仪电量
        public string SENSORPOWER
        {
            get { return sensorPower; }
            set { sensorPower = value; }
        }

        //数据采集时间
        public string DATATIME
        {
            get { return dataTime; }
            set { dataTime = value; }
        }

        //数据记录时间
        public string RECORDTIME
        {
            get { return recordTime; }
            set { recordTime = value; }
        }
    }
}
