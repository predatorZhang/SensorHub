using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SensorHub.Model;
using SensorHub.IDAL;

namespace SensorHub.BLL
{
    public class DjNoise
    {
        /// <summary>
        /// A method to insert a new Adapter
        /// </summary>
        /// <param name="noise">An adapter entity with information about the new adapter</param>
        public void insert(DjNoiseInfo noise)
        {
            // Validate input
            if (noise.DBID <= 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(noise.DEVID))
            {
                return;
            }
            IDjNoise dal = SensorHub.DALFactory.DjNoise.Create();
            dal.insert(noise);

        }
    }
}
