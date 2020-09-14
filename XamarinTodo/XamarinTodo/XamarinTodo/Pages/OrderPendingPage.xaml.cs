using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPendingPage : ContentPage
    {
        public OrderPendingPage()
        {
            InitializeComponent();
        }

        private async void AcceptOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderAcceptetPage());
        }

        private async void DeclineOrderSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDeclinePage());
        }
    }
}