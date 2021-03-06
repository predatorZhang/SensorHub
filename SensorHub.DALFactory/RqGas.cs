﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SensorHub.DALFactory
{
    public class RqGas
    {
        public static SensorHub.IDAL.IRqGas Create()
        {
            /// Look up the DAL implementation we should be using
            string path = System.Configuration.ConfigurationSettings.AppSettings["RqGasDAL"];
            string className = path + ".RqGas";

            // Using the evidence given in the config file load the appropriate assembly and class
            return (SensorHub.IDAL.IRqGas)Assembly.Load(path).CreateInstance(className);
        }
    }
}
