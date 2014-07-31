using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
     [Serializable]
    public class AlarmInfo
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

         public virtual Device device
         {
             get;
             set;
         }

         public virtual string alarmContent
         {
             get;
             set;
         }

         public virtual DateTime alarmDate
         {
             get;
             set;
         }

         public virtual string currentState
         {
             get;
             set;
         }

         public virtual AlarmHandler handlers
         {
             get;
             set;
         }
        
    }
}
