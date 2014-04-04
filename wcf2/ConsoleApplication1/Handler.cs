using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Handler: ServiceReference2.IService1Callback
    {
        public void UstawProcent(int pct)
        {
            Console.WriteLine(pct);
        }
    }
}
