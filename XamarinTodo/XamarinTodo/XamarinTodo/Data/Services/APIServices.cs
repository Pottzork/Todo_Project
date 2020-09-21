using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public class APIServices : IAPIService<OrderOverView>
    {
        public async Task<List<OrderOverView>> GetOrderOverViewAsync(int operatorId)
        {
            HttpClient client = new HttpClient();

            string url = $"https://webapitodo20200919020315.azurewebsites.net/api/OrderOverView/{operatorId}?fbclid=IwAR1LMi7ghiTGQfhdmu_fQjDHqNIEx9ZPAiC5IadZZCEVBB4dkpftx3DjZdI";

            var response = client.GetAsync(url);
            var result = response.Result;

            string json = result.Content.ReadAsStringAsync().Result;

            var orderList = JsonConvert.DeserializeObject<List<OrderOverView>>(json);

            return orderList;
        }
    }
}