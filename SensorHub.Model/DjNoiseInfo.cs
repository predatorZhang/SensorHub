using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorHub.Model
{
    public class DjNoiseInfo
    {
        private long dbId;
        private long devId;
        private string looseData;
        private string denseData;
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
