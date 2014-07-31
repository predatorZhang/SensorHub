using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    [Serializable]
    public class DeviceParamExtension
    {
        public virtual int dbID
        {
            get;
            set;
        }
        public virtual string paramName
        {
            get;
            set;
        }
        public virtual string paramType
        {
            get;
            set;
        }
        public virtual string paramValue
        {
            get;
            set;
        }
        public virtual int paramOrder
        {
            get;
            set;
        }
        public virtual Device device
        {
            get;
            set;
        }
    }
}
