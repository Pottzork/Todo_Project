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
    public partial class OrderDeclinePage : ContentPage
    {
        public OrderDeclinePage()
        {
            InitializeComponent();
        }

        private async void SendReason_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Är du säker på att du vill avböja order?", "Nej.", "Ja!");
        }
    }
}