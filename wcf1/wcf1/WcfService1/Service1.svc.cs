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
     //   [FaultContract Exception]
        public string GetData(int value)
        {
            if (value < 0)
            {
                MyExceptionContainer exDetail = new MyExceptionContainer();
                exDetail.Messsage = "Mniejsze od zera";
                exDetail.Description = "Wpisana liczba jest mniejsza od zera";
                throw new FaultException<MyExceptionContainer>(exDetail);
            }
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
