using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ServiceReference2.Service1Client(new System.ServiceModel.InstanceContext(new Handler()));
            c.LongOperation(10);
            Console.Read();
        }
    }
}
