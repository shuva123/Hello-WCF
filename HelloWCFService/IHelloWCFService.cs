using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloWCFService" in both code and config file together.
    [ServiceContract(Name = "IHelloWCFService")]
    public interface IHelloWCFServiceChanged
    {
        [OperationContract(Name = "getMessage")]
        string getMessageChanged(string name);
    }
}
