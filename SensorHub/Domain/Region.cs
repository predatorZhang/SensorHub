using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    [Serializable]
    public class Region
    {
        public virtual int dbID
        {
            get;
            set;
        }

        public virtual string regionName
        {
            get;
            set;
        }

        public virtual Region parent
        {
            get;
            set;
        }

        public virtual IList<Device> devices
        {
            get;
            set;
        }

        public virtual IList<Region> children
        {
            get;
            set;
        }

        public virtual IList<MonitoringPost> posts
        {
            get;
            set;
        }

        public virtual IList<AlarmInfo> alarmInfos
        {
            get;
            set;
        }
    }
}
