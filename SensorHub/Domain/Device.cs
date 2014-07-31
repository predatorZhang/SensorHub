using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
     [Serializable]
    public class Device
    {
        public virtual int dbID
        {
            get;
            set;
        }

        public virtual Region region
        {
            get;
            set;
        }

        public virtual DeviceType deviceType
        {
            get;
            set;
        }

        public virtual double longitude
        {
            get;
            set;
        }

        public virtual double latitude
        {
            get;
            set;
        }

        public virtual string macID
        {
            get;
            set;
        }

        public virtual Boolean isAvailable
        {
            get;
            set;
        }

        public virtual IList<DeviceParamExtension> deviceParams
        {
            get;
            set;
        }

        public virtual MonitoringPost post
        {
            get;
            set;
        }

        public virtual IList<AlarmInfo> alarmInfo
        {
            get;
            set;
        }
     
    }
}
