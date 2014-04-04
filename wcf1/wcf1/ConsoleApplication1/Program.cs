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
            ServiceReference1.Service1SoapClient client = new ServiceReference1.Service1SoapClient();
            Console.WriteLine(client.HelloWorld());
        }
    }
}
