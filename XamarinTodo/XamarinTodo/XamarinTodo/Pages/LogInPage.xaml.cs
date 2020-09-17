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
        //Denna används för att nå metoderna i serviceklassen
        public IDataService<Orders> DataService => DependencyService.Get<IDataService<Orders>>();

        public LogInPage()
        {
            InitializeComponent();
        }

        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new OrderOverviewPage()));

            //Detta ska inte ligga här. Bara för att testa hämtning av MockData
            //List<Orders> ordersList = new List<Orders>();

            //ordersList = await DataService.GetItemsAsync() as List<Orders>;
        }
    }
}