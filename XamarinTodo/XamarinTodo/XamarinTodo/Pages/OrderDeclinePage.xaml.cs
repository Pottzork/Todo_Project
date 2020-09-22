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
            var answer = await DisplayAlert("Alert", "Är du säker på att du vill avböja order?", "Nej.", "Ja!");

            if (answer ==true)
            {
                DeclineOrder();
                await Navigation.PushModalAsync(new NavigationPage(new OrderOverviewPage()));
            }
            

        }


        public void DeclineOrder()
        {
            Order.OrderStatus = OrderStatus.EJ_ACCEPTERAD;
            DateTime timeLogNow = DateTime.Now;

            string respId = OrderOverView.OperatorID.ToString();
            string respText = txtOrderDeclineReason.Text;
            string respTime = timeLogNow.ToString();

            Order.OrderDeclineReason = $"-{respId}- {respTime} : {respText}";

            Service.UpdateOrderAsync(Order);

            
        }
    }
}
