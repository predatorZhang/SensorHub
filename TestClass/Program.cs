using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SensorHub.Model;
using System.Reflection;
using SensorHub.BLL;

namespace TestClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DjFlowTest();
        }

        public static void DjFlowTest()
        {
            try
            {
                DjFlow bll = new DjFlow();
                DjFlowInfo info = new DjFlowInfo();
                info.DBID = 123;
                info.DEVID = 456;
                info.INSDATA = "abc";
                info.NEGDATA = "efg";
                info.POSDATA = "hij";
                info.NEGDATA = "lnm";
                info.FLOWPOWER = "15";
                info.SENSORPOWER = "67";
                info.DATATIME = (new DateTime()).ToShortDateString();
                info.RECORDTIME = (new DateTime()).ToShortDateString();
                bll.insert(info);
                Console.WriteLine("保存成功！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public static void DjPressTest()
        {
            DjPressInfo info = new DjPressInfo();
        }
    }
}
