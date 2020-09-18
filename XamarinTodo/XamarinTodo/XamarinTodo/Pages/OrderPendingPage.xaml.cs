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
    public partial class OrderPendingPage : ContentPage
    {
        public Orders PendingOrder;

        public OrderPendingPage(Orders pendingOrder)
        {
            PendingOrder = new Orders();
            PendingOrder = pendingOrder;

            InitializeComponent();

            LabelCustomerId.Text = PendingOrder.OrderId.ToString();
            LabelOrderDescription.Text = PendingOrder.OrderDescription;
        }

        private async void AcceptOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderAcceptedPage(PendingOrder));
        }

        private async void DeclineOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDeclinePage());
        }
    }
}