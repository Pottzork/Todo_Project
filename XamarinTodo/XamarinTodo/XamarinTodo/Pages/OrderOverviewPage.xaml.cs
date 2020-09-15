using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Data.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderOverviewPage : ContentPage
    {
        public OrderOverviewPage()
        {
            InitializeComponent();
            GetOrders();
        }

        private void OrderTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderPendingPage());
        }

        private void GetOrders()
        {
            var path = "/Orders";
            var order = ToDoServices.GetRequest(path);
        }

        //Om OrderAccept = false så ska den visas här
        //Samt att OrderComplete är false.
        //Visa accepterade orders knutna till rätt OpId
    }
}