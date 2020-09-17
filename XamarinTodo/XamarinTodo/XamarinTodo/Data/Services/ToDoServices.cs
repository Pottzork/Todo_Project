using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;




namespace XamarinTodo.Data.Services
{
    public class ToDoServices
    {

        private const string HOST = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static string GetRequest(string path)
        {
            var client = new HttpClient();

            var data = client.GetAsync(HOST);
            var result = data.Result;

            string jsonData = result.Content.ReadAsStringAsync().Result;

            return jsonData;
        }
    }
}
