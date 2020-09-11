using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTodo.Pages;

namespace XamarinTodo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OrderOverviewPage();
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