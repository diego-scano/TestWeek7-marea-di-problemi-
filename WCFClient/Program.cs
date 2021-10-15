using ShopService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ShopServiceClient client = new ShopServiceClient();

            List<Customer> customers = await client.FetchCustomersAsync();

            foreach (Customer customer in customers)
                Console.WriteLine($"{customer.Id}");
        }
    }
}
