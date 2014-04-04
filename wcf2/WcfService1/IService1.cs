using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface IZwrotny
    {
        [OperationContract(IsOneWay=true)]
        void UstawProcent(int x);
    }

    [ServiceContract(CallbackContract = typeof(IZwrotny))]
    public interface IService1
    {

        [OperationContract(IsOneWay=true)]
        void LongOperation(int i);
        

        // TODO: Add your service operations here
    }

}
