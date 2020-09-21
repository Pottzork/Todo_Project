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
    public partial class OrderDoneAddInfoPage : ContentPage
    {
        public IAPIService Service => DependencyService.Get<IAPIService>();

        public OrderOverView OrderOverView { get; set; }
        public Orders Order { get; set; }

        public OrderDoneAddInfoPage(OrderOverView orderOverView)
        {
            InitializeComponent();
            OrderOverView = orderOverView;
        }

        private async void ConfirmInfo_Clicked(object sender, EventArgs e)
        {
            Order = await Service.GetOrderAsync(OrderOverView.OrderId);
            bool displayAlertAnswer = await DisplayAlert("Alert", "Är du säker på att du vill markera order som klar?", "Ja!", "Nej.");
            if (displayAlertAnswer)
            {
                Order.OrderStatus = OrderStatus.KLAR;
                await Service.UpdateOrderAsync(Order);
            }
        }
    }
}