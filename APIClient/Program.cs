using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:44339/api/orders")
            };

            HttpResponseMessage httpResponse = await client.SendAsync(httpRequest);

            if (httpResponse.IsSuccessStatusCode)
            {
                string jsonData = await httpResponse.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<OrderContract>>(jsonData);

                foreach (var item in results)
                    Console.WriteLine($"{item.Id}");
            }
        }
    }
}
