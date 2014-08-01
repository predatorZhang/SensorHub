using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorHub.Model
{
    public class DjLiquidInfo
    {
        private long dbId;
        private string devId;
        private string pressData;
        private string liquidPower;
        private string sensorPower;
        private string dataTime;
        private string recordTime;

        public long DBID
        {
            get { return dbId; }
            set { dbId = value; }
        }

        public string DEVID
        {
            get { return devId; }
            set { devId = value; }
        }

        public string LIQUIDDATA
        {
            get { return pressData; }
            set { pressData = value; }
        }
        public string LIQUIDPOWER
        {
            get { return liquidPower; }
            set { liquidPower = value; }
        }
        public string SENSORPOWER
        {
            get { return sensorPower; }
            set { SENSORPOWER = value; }
        }
        public string DATATIME
        {
            get { return dataTime; }
            set { dataTime = value; }
        }
        public string RECORDTIME
        {
            get { return recordTime; }
            set { recordTime = value; }
        }
    }
}
