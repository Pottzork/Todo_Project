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
    public partial class OrderPendingPage : ContentPage
    {
        public IAPIService Service => DependencyService.Get<IAPIService>();

        public OrderOverView OrderOverView;
        private Orders _order;

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
            //Här ska OrderStatus uppdateras
            if (OrderOverView != null)
            {
                _order = await Service.GetOrderAsync(OrderOverView.OrderId);

                _order.OrderStatus = OrderStatus.ACCEPTERAD;
                await Service.UpdateOrderAsync(_order);

                await Navigation.PushAsync(new OrderOverviewPage());

                DependencyService.Get<IToastMessage>().LongAlert("Order Accepterad");
            }
        }

        private async void DeclineOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDeclinePage(OrderOverView));
        }
    }
}