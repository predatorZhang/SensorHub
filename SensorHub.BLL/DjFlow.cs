using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SensorHub.Model;
using SensorHub.IDAL;

namespace SensorHub.BLL
{
    public class DjFlow
    {
        /// <summary>
        /// A method to insert a new Adapter
        /// </summary>
        /// <param name="flow">An adapter entity with information about the new adapter</param>
        public void insert(DjFlowInfo flow)
        {
            // Validate input
            if (flow.DBID <= 0)
            {
                return;
            }
            if (flow.DEVID <= 0)
            {
                return;
            }
            IDjFlow dal = SensorHub.DALFactory.DjFlow.Create();
            dal.insert(flow);

        }
    }
}
