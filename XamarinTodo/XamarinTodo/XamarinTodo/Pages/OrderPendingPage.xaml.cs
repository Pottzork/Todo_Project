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

        private OrderOverView _orderOverView;
        private Orders _order;

        public OrderPendingPage(OrderOverView orderOverView)
        {
            _orderOverView = new OrderOverView();
            _orderOverView = orderOverView;

            InitializeComponent();

            LabelCustomerName.Text = _orderOverView.Company;
            LabelAdress.Text = _orderOverView.FullAdress;
            LabelPhone.Text = _orderOverView.Phone;
            LabelContactPerson.Text = _orderOverView.Name;
            LabelOrderInfo.Text = _orderOverView.OrderInfo;
            LabelOrderDescription.Text = _orderOverView.OrderDescription;
        }

        private async void AcceptOrderSwipe_Invoked(object sender, EventArgs e)
        {
            if (_orderOverView != null)
            {
                _order = await Service.GetOrderAsync(_orderOverView.OrderId);

                _order.OrderStatus = OrderStatus.ACCEPTERAD;
                await Service.UpdateOrderAsync(_order);

                await Navigation.PushAsync(new OrderOverviewPage());

                DependencyService.Get<IToastMessage>().LongAlert("Order Accepterad");
            }
        }

        private async void DeclineOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDeclinePage(_orderOverView));
        }
    }
}