using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public static IZwrotny Callback;
        public void LongOperation(int i)
        {
            Console.WriteLine("Wywołanie długiej operacji");

            Callback = OperationContext.Current.GetCallbackChannel<IZwrotny>();
           
            for (int j = 0; j <= i; j++)
            {
                System.Threading.Thread.Sleep(1000);
                Callback.UstawProcent(j * 10);
            }
        }
    }
}
