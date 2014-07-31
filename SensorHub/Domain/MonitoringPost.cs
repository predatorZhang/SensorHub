using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    [Serializable]
    public class MonitoringPost
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

        public virtual IList<Device> devices
        {
            get;
            set;
        }

        public virtual string postName
        {
            get;
            set;
        }

       
    }
}
