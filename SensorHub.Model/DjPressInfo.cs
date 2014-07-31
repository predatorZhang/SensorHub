using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorHub.Model
{
    public class DjPressInfo
    {
        private long dbId;
        private long devId;
        private string pressData;
        private string pressPower;
        private string sensorPower;
        private string dataTime;
        private string recordTime;

        public long DBID
        {
            get { return dbId; }
            set { dbId = value; }
        }

        public long DEVID
        {
            get { return devId; }
            set { devId = value; }
        }

        public string PRESSDATA
        {
            get { return pressData; }
            set { pressData = value; }
        }
        public string PRESSPOWER
        {
            get { return pressPower; }
            set { pressPower = value; }
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
