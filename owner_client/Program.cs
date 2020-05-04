using System;
using System.Net.Http;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace owner_client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("host?(httpもしくはhttpsから入力)");
            var host = Console.ReadLine();

            var alert = new AlertModel();
            Console.WriteLine("head?");
            alert.Head = Console.ReadLine();
            Console.WriteLine("body?");
            alert.Body = Console.ReadLine();
            Console.WriteLine("送信中");
            using (var ms = new MemoryStream())
            using (var sr = new StreamReader(ms))
            {
                var serializer = new DataContractJsonSerializer(typeof(AlertModel));
                serializer.WriteObject(ms, alert);
                ms.Position = 0;

                var json = sr.ReadToEnd();

                
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(host+"/api/Alert", new StringContent(json, Encoding.UTF8, @"application/json"));
                }
            }
            
            Console.WriteLine("送信完了");
        }
    }
}
