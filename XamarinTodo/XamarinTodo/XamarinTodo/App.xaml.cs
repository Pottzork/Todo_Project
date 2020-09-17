using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTodo.Data.Services;
using XamarinTodo.Pages;

namespace XamarinTodo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<DataService>();

            MainPage = new LogInPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}