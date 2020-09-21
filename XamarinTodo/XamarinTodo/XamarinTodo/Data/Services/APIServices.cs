using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public class APIServices : IAPIService
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

        public async Task<Orders> GetOrderAsync(int orderId)
        {
            HttpClient client = new HttpClient();

            string url = $"https://webapitodo20200919020315.azurewebsites.net/api/orders/{orderId}?fbclid=IwAR3YpHnjZQCX77z2L21w1ypG0OSFqr8zTtZ0B-tHFMaoU9F9gVQHgmcYXDU";

            var response = client.GetAsync(url);
            var result = response.Result;

            string json = result.Content.ReadAsStringAsync().Result;

            var order = JsonConvert.DeserializeObject<Orders>(json);

            return order;
        }

        public async Task UpdateOrderAsync(Object objectclass)
        {
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(objectclass, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync("https://webapitodo20200919020315.azurewebsites.net/api/orders?fbclid=IwAR3YpHnjZQCX77z2L21w1ypG0OSFqr8zTtZ0B-tHFMaoU9F9gVQHgmcYXDU", content);
        }
    }
}