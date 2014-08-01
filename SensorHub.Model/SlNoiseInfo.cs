using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorHub.Model
{
    public class SlNoiseInfo
    {
        private long dbId;
        private string devId;
        private string looseData;
        private string denseData;
        private string sensorPower;
        private string dataTime;
        private string recordTime;

        public long DBID
        {
            get { return dbId;}
            set { dbId = value; }
        }

        public string DEVID
        {
            get { return devId; }
            set { devId = value; }
        }

        public string LOOSEDATA
        {
            get { return looseData; }
            set { looseData = value; }
        }

        public string DENSEDATA
        {
            get { return denseData; }
            set { denseData = value; }
        }

        public string SENSORPOWER
        {
            get { return sensorPower; }
            set { sensorPower = value; }
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
