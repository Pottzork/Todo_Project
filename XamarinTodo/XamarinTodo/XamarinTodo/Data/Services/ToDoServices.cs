using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace XamarinTodo.Data.Services
{
    public class ToDoServices
    {
        private const string HOST = "https://localhost:44374/api";

        public static string GetRequest(string path)
        {
            var client = new HttpClient();

            var data = client.GetAsync(HOST + path);
            var result = data.Result;

            string jsonResult = result.Content.ReadAsStringAsync().Result;

            return jsonResult;
        }
    }
}