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
    public partial class OrderOverviewPage : ContentPage
    {
        public List<NewOrder> NewOrder { get; set; }

        public OrderOverviewPage(List<NewOrder> newOrder)
        {
            this.NewOrder = newOrder;
        }

        public OrderOverviewPage()
        {
            InitializeComponent();
        }

        private void OrderTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderPendingPage());
        }



        //Om OrderAccept = false så ska den visas här
        //Samt att OrderComplete är false.
        //Visa accepterade orders knutna till rätt OpId


    }

  
}