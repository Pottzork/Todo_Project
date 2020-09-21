using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public class APIServices : IAPIService<Orders>
    {
        public async Task<List<Orders>> GetOrdersAsync()
        {
            HttpClient client = new HttpClient();

            string url = $"https://webapitodo20200919020315.azurewebsites.net/api/orders?fbclid=IwAR3FZspzBRxFAIOgpEViHZYRJAyfBm_x8SR4pyiTCznMMHW1L9vaLt8n2VE";

            var response = client.GetAsync(url);
            var result = response.Result;

            string json = result.Content.ReadAsStringAsync().Result;

            var orderList = JsonConvert.DeserializeObject<List<Orders>>(json);

            return orderList;
        }
    }
}