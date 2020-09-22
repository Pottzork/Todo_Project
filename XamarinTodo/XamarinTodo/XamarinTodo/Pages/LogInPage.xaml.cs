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
    public partial class LogInPage : ContentPage
    {
        private string UserName;
        private string Password;

        public LogInPage()
        {
            InitializeComponent();
        }

        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            UserName = EntryUsername.Text;
            Password = EntryPassword.Text;

            await Navigation.PushModalAsync(new NavigationPage(new OrderOverviewPage()));
        }
    }
}