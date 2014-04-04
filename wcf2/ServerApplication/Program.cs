using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(AppService), new Uri[] { new Uri("http://localhost:11000") });
            host.AddServiceEndpoint(typeof(IService1), new WSDualHttpBinding(), "Usluga");
            var b = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (b == null)
                b = new ServiceMetadataBehavior();
            host.Description.Behaviors.Add(b);
            host.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            host.Open();

            while (Console.Read() != 'q')
            { }
            host.Close();
        }
    }
}
