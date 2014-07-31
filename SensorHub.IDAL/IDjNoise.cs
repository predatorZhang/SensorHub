using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SensorHub.Model;

namespace SensorHub.IDAL
{
    public interface IDjNoise
    {
        void insert(DjNoiseInfo noise);
    }
}
