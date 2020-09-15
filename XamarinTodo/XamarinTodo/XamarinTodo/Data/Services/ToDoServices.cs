using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTodo.Data.Services
{
    public class ToDoServices
    {
        private const string HOST = "https://10.0.2.2:44374/api";

        public async Task NewGetRequest(string path)
        {
            var client = new HttpClient();

            var data = await client.GetAsync(HOST + path);

            string result = data.Content.ReadAsStringAsync().Result;

            //return jsonResult;
        }

        public static string GetRequest(string path)
        {
            var client = new HttpClient();

            var response = client.GetAsync(HOST + path);
            var statusCode = response.Result;

            string result = statusCode.Content.ReadAsStringAsync().Result;

            return result;
        }
    }
}