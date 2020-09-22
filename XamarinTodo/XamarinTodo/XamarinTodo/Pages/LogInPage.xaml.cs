using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTodo.Data;
using XamarinTodo.Data.Services;
using XamarinTodo.Models;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public IAPIService Service => DependencyService.Get<IAPIService>();

        private List<Operators> _operatorList;

        private string UserName;
        private string Password;

        public LogInPage()
        {
            InitializeComponent();
            GetOperators();
        }

        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            UserName = EntryUsername.Text;
            Password = EntryPassword.Text;

            foreach (var op in _operatorList)
            {
                if (op.UserName == UserName && op.Password == Password)
                {
                    ActiveUser.Operator = op;
                    await Navigation.PushModalAsync(new NavigationPage(new OrderOverviewPage()));
                    return;
                }
            }

            DependencyService.Get<IToastMessage>().LongAlert("Fel Andvändarnamn / Lösenord");
            EntryUsername.Text = "";
            EntryPassword.Text = "";
        }

        private async void GetOperators()
        {
            _operatorList = await Service.GetOperatorsAsync();
        }
    }
}