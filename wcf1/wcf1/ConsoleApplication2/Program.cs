using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                Console.WriteLine(client.GetData(3).ToString());
            }
            catch (System.ServiceModel.FaultException<ServiceReference1.MyExceptionContainer> ex)
            {
                Console.WriteLine(ex.Detail.Messsage);
                Console.WriteLine(ex.Detail.Description);
            }

            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {                
                IAsyncResult res = client.BeginGetData(-5, Callback, client); 
            }
            //res.Wa
            Console.Read();

        }
        static void Callback(IAsyncResult res)
        {
            var client = (ServiceReference1.Service1Client)res.AsyncState;
            try
            {
                Console.WriteLine(client.EndGetData(res).ToString());
            }
            catch (System.ServiceModel.FaultException<ServiceReference1.MyExceptionContainer> ex)
            {
                Console.WriteLine(ex.Detail.Messsage);
                Console.WriteLine(ex.Detail.Description);
            }
        }
    }
}
