using System;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace user_client
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("host?(httpもしくはhttpsから入力)");
            var host = Console.ReadLine();
            while (true)
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(host+"/api/Alert/latest");
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                }
                Thread.Sleep(10000);
            }
        }
    }
}
