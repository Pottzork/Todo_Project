using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;




namespace XamarinTodo.Data.Services
{
    public class ToDoServices
    {

        private const string HOST = "https://www.obvibase.com/app/?location=%7B%22type%22%3A%22token%22%2C%22token%22%3A%7B%22type%22%3A%22rw%22%2C%22databaseId%22%3A%22Ai6SRcFaWkVQsMce%22%2C%22token%22%3A%22UHjGeG2JFizZNCCD%22%7D%7D";

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
