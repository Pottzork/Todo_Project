using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTodo.Models;
using XamarinTodo.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.SqlServer.Management.Smo;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderOverviewPage : ContentPage
    {
        List<Admins> admins { get; set; }

        public OrderOverviewPage()
        {
            
            InitializeComponent();
            Admins();
            
        }

        public async void Admins()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://10.0.0.2:44374/api/Admins");
            var admins = JsonConvert.DeserializeObject<List<Admins>>(response);

            

        }
   
        

        private void OrderTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderPendingPage());
        }


   

        private void Button_Clicked(object sender, EventArgs e)
        {
     



        }





        //Om OrderAccept = false så ska den visas här
        //Samt att OrderComplete är false.
        //Visa accepterade orders knutna till rätt OpId


    }
}