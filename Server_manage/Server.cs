using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Server_manage
{   
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        private static string returnApiString()
        {
            WebClient client = new WebClient();
            string htmlCode = client.DownloadString("https://vapi.vnappmob.com/api/request_api_key?scope=exchange_rate");
            return htmlCode;
        }
        private static async Task GetFromCompaniesHouse()
        {
            string s = returnApiString();
            var url = "https://vapi.vnappmob.com/api/v2/exchange_rate/vcb";
            var apiKey = s.Substring(12, s.IndexOf('}') - 13);
            //"eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzgzNzAyMDQsImlhdCI6MTYzNzA3NDIwNCwic2NvcGUiOiJleGNoYW5nZV9yYXRlIiwicGVybWlzc2lvbiI6MH0.oeSBlDDMDYab-wG9gmUQuNHHWM_xaLvaQzjRKmPR0Dc";
            var encodedKey = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(apiKey));
            using (var client = new HttpClient()){
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Headers.Add("Authorization", $"Basic {apiKey}");
                var response = await client.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();
                int size = content.ToString().Length;
                string jsonString = content.ToString();
                Root value = JsonConvert.DeserializeObject<Root>(jsonString);
                Console.WriteLine(value.results.Count);
                /*foreach (Result item in value.results)
                {
                    Console.WriteLine($"Buy_cash:{item.buy_cash}");
                    Console.WriteLine($"Buy_transfer:{item.buy_transfer}");
                    Console.WriteLine($"Currency:{item.currency}");
                    Console.WriteLine($"Sell:{item.sell}");
                    Console.WriteLine("-----------------------------");
                }*/
            }
        }
        public class Result{
            public double buy_cash { get; set; }
            public double buy_transfer { get; set; }
            public string currency { get; set; }
            public double sell { get; set; }
        }

        public class Root{
            public List<Result> results { get; set; }
            //private List<Result> esults { get; set; }
        }
        //https://stackoverflow.com/questions/41683798/convert-json-from-get-request-into-text-boxes-in-c-sharp-winforms-application
    }
}
