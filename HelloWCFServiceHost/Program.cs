﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWCFServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloWCFService.HelloWCFService)))
            {
                host.Open();
                Console.WriteLine("Host started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
