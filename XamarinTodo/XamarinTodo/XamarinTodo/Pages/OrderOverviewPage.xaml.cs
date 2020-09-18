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
        public IDataService<Orders> DataService => DependencyService.Get<IDataService<Orders>>();

        private List<Orders> orderList;

        public OrderOverviewPage()
        {
            InitializeComponent();
            GetOrders();

            orderOverviewList.ItemsSource = orderList;
        }

        private async void GetOrders()
        {
            orderList = await DataService.GetOrdersAsync() as List<Orders>;
        }

        private async void orderOverviewList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new OrderPendingPage(e.CurrentSelection[0] as Orders));
        }

        public void temp()
        {
            JoinStuffThingy.Demo();
        }

        //Om OrderAccept = false så ska den visas här
        //Samt att OrderComplete är false.
        //Visa accepterade orders knutna till rätt OpId
    }
}