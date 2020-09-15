﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderOverviewPage : ContentPage
    {
        public OrderOverviewPage()
        {
            InitializeComponent();
        }

        private void OrderTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderPendingPage());
        }
    }
}