using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTodo.Models;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderAcceptedPage : ContentPage
    {
        private Orders AcceptedOrder;

        public OrderAcceptedPage(Orders acceptedOrder)
        {
            AcceptedOrder = new Orders();
            AcceptedOrder = acceptedOrder;

            InitializeComponent();

            LabelCustomerId.Text = AcceptedOrder.OrderId.ToString();
            LabelOrderDescription.Text = AcceptedOrder.OrderDescription;
        }

        private async void AddInfoSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDoneAddInfoPage());
        }
    }
}