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
    public partial class OrderAcceptetPage : ContentPage
    {
        public OrderAcceptetPage()
        {
            InitializeComponent();
        }

        private async void AddInfoSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDoneAddInfoPage());
        }
    }
}