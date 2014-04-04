using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ServerApplication
{
 
    public interface IZwrotny
    {
        [OperationContract(IsOneWay = true)]
        void UstawProcent(int x);
    }

    [ServiceContract(CallbackContract = typeof(IZwrotny), SessionMode = SessionMode.Allowed)]
    public interface IService1
    {

        [OperationContract(IsOneWay = true)]
        void LongOperation(int i);
    }
    
}
