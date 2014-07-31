using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    [Serializable]
    public class AlarmHandler
    {
        public virtual int dbID
        {
            get;
            set;
        }

        public virtual string alarmHandlerName
        {
            get;
            set;
        }

        public virtual string phoneNumber
        {
            get;
            set;
        }

        public virtual IList<Device> devices
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
