using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CustomerService)))
            {
                host.Open();

                Console.WriteLine("Customer WCF Running");
                Console.ReadKey();
            }
        }
    }
}
