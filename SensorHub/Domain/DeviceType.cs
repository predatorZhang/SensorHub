using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
     [Serializable]
    public class DeviceType
    {
        public virtual int dbID
        {
            get;
            set;
        }

        public virtual int deviceName
        {
            get;
            set;
        }

        public virtual Boolean isAvailbale
        {
            get;
            set;
        }

        public virtual IList<Device> devices
        {
            get;
            set;
        }

    }
}
