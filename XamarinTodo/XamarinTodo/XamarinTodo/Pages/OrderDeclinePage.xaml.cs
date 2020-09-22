using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTodo.Data.Services;
using XamarinTodo.Models;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDeclinePage : ContentPage
    {

        public IAPIService Service => DependencyService.Get<IAPIService>();

        public OrderOverView OrderOverView { get; set; }
        public Orders Order { get; set; }


        public OrderDeclinePage()
        {
            InitializeComponent();
        }

        private async void SendReason_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Är du säker på att du vill avböja order?", "Nej.", "Ja!");

            Order.OrderStatus = OrderStatus.EJ_ACCEPTERAD;

            DeclineOrder();

            await Navigation.PushModalAsync(new NavigationPage(new OrderOverviewPage()));

        }


        public void DeclineOrder()
        {
            DateTime timeLogNow = DateTime.Now;
            //StringBuilder orderDeclineBuilder = null;

            string respId = OrderOverView.OperatorID.ToString();
            string respText = txtOrderDeclineReason.Text;
            string respTime = timeLogNow.ToString();

            Order.OrderDeclineReason.AppendLine($"-{respId}- {respTime} : {respText}");

            //orderDeclineBuilder.AppendLine($"-{respId}- {respTime} : {respText}");

            //Order.OrderDeclineReason = orderDeclineBuilder.ToString();




            //Add string OrderDeclineReason to DB
            //Update DB with new OrderDeclineReason
            //Link for stringbuilder in DB: 
            //       https://www.tutorialsteacher.com/csharp/csharp-stringbuilder
        }



    }
}
