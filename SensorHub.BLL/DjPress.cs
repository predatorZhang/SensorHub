using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SensorHub.Model;
using SensorHub.IDAL;

namespace SensorHub.BLL
{
    public class DjPress
    {
        /// <summary>
        /// A method to insert a new Adapter
        /// </summary>
        /// <param name="press">An adapter entity with information about the new adapter</param>
        public void insert(DjPressInfo press)
        {
            // Validate input
            if (press.DBID <= 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(press.DEVID))
            {
                return;
            }
            IDjPress dal = SensorHub.DALFactory.DjPress.Create();
            dal.insert(press);

        }
    }
}
