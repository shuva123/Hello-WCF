using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloWCFService" in both code and config file together.
    public class HelloWCFService : IHelloWCFServiceChanged
    {
        public string getMessageChanged(string name)
        {
            return "Hello " + name;
        }
    }
}
