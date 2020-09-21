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
        public OrderOverView OrderOverView;

        public OrderPendingPage(OrderOverView orderOverView)
        {
            OrderOverView = new OrderOverView();
            OrderOverView = orderOverView;

            InitializeComponent();

            LabelCustomerName.Text = OrderOverView.Company;
            LabelCustomerId.Text = OrderOverView.OrderId.ToString();
            LabelAdress.Text = OrderOverView.Street;
            LabelContactPerson.Text = OrderOverView.Name;
            LabelOrderDescription.Text = OrderOverView.OrderDescription;
        }

        private async void AcceptOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderAcceptedPage(OrderOverView));
        }

        private async void DeclineOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDeclinePage());
        }
    }
}