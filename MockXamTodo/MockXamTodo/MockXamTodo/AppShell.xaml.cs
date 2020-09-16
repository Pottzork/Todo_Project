using System;
using System.Collections.Generic;
using MockXamTodo.ViewModels;
using MockXamTodo.Views;
using Xamarin.Forms;

namespace MockXamTodo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
