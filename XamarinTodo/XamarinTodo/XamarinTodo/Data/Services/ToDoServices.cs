using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;




namespace XamarinTodo.Data.Services
{
    public class ToDoServices
    {

        private const string HOST = "https://localhost:44374/api/";

        public static void GetRequest()
        {
            var client = new HttpClient();
            string path = "/Admins";
            var data = client.GetAsync(HOST + path);
            var result = data.Result;

            string jsonData = result.Content.ReadAsStringAsync().Result;

            //return jsonData;
        }
    }
}
