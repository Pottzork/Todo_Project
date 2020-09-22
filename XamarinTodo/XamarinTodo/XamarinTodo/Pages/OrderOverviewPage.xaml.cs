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
    public partial class OrderOverviewPage : ContentPage
    {
        public IAPIService Service => DependencyService.Get<IAPIService>();

        private List<OrderOverView> _orderOverViewList;

        public int OperatorId { get; set; } = 27;

        public OrderOverviewPage()
        {
            InitializeComponent();
            GetOrders();
            SetBgColor();
            orderOverviewList.ItemsSource = _orderOverViewList;
        }

        private async void GetOrders()
        {
            var tempList = await Service.GetOrderOverViewAsync(OperatorId);
            _orderOverViewList = SortOrders(tempList).ToList();
        }

        private void SetBgColor()
        {
            foreach (var order in _orderOverViewList)
            {
                if (order.OrderStatus == OrderStatus.FAKTURA_SKICKAD)
                {
                    order.BgColor = "#FFF";
                }
                else if (order.OrderStatus == OrderStatus.KLAR)
                {
                    order.BgColor = "#000";
                }
            }
        }

        private async void orderOverviewList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new OrderPendingPage(e.CurrentSelection[0] as OrderOverView));
        }

        public IEnumerable<OrderOverView> SortOrders(List<OrderOverView> orders)
        {
            var sortedOrders = orders.OrderBy(x => x.OrderStart.Date)
                .ThenBy(x => x.OrderStart.TimeOfDay);

            return sortedOrders;
        }

        //public void temp()
        //{
        //    JoinStuffThingy.Demo();
        //}

        //Om OrderAccept = false så ska den visas här
        //Samt att OrderComplete är false.
        //Visa accepterade orders knutna till rätt OpId
    }
}