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
            StringBuilder sb = new StringBuilder("123,3456,");
            Console.Write(sb.Remove(sb.Length-1,1).ToString());
            Console.Read();
        }
    }
}
