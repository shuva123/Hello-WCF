using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceHost1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(HelloWCFService1.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
