using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ServerApplication
{
    [ServiceBehavior(IncludeExceptionDetailInFaults=true, InstanceContextMode=InstanceContextMode.PerSession)]
    class AppService : IService1
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
