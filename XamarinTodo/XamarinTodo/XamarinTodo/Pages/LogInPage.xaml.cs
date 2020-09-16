using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using XamarinTodo.Data.Services;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]




    public partial class LogInPage : ContentPage
    {



        public LogInPage()
        {
            InitializeComponent();
        }





        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new OrderOverviewPage()));
        }
    }
}