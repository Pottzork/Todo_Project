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

        public OrderDeclinePage(OrderOverView orderOverView)
        {
            OrderOverView = orderOverView;
            InitializeComponent();
        }

        private async void SendReason_Clicked(object sender, EventArgs e)
        {
            Order = new Orders();
            Order = await Service.GetOrderAsync(OrderOverView.OrderId);

            var answer = await DisplayAlert("Alert", "Är du säker på att du vill avböja order?", "Ja!", "Nej.");

            if (answer == true)
            {
                DeclineOrder();
                await Navigation.PushModalAsync(new NavigationPage(new OrderOverviewPage()));
            }
        }

        public void DeclineOrder()
        {
            Order.OrderStatus = OrderStatus.NEKAD;
            DateTime timeLogNow = DateTime.Now;

            //string respId = OrderOverView.OperatorID.ToString(); Används ej längre. Finns i Blazor
            string respText = txtOrderDeclineReason.Text;
            string respTime = timeLogNow.ToString("yyyy-MM-dd HH:mm");

            Order.OrderDeclineReason = $" {respTime} : {respText}";

            Service.UpdateOrderAsync(Order);
        }
    }
}