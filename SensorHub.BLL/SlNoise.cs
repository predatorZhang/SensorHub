using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SensorHub.Model;
using SensorHub.IDAL;

namespace SensorHub.BLL
{
    public class SlNoise
    {
        /// <summary>
        /// A method to insert a new Adapter
        /// </summary>
        /// <param name="noise">An adapter entity with information about the new adapter</param>
        public void insert(SlNoiseInfo noise)
        {
            // Validate input
            if (noise.DBID <= 0)
            {
                return;
            }
            if (noise.DEVID <= 0)
            {
                return;
            }
            ISlNoise dal = SensorHub.DALFactory.SlNoise.Create();
            dal.insert(noise);

        }
    }
}
