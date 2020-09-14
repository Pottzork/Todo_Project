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
    public partial class OrderDoneAddInfoPage : ContentPage
    {
        public OrderDoneAddInfoPage()
        {
            InitializeComponent();
        }

        private async void ConfirmInfo_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Är du säker på att du vill markera order som klar?", "Nej.", "Ja!");
        }
    }
}