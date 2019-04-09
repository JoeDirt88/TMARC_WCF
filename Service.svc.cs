using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TMARC_1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceInterface" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceInterface.svc or ServiceInterface.svc.cs at the Solution Explorer and start debugging.
    public class Service : IServiceInterface
    {
        public string GetData(int value)
        {
            return $"You entered: {value}";
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
