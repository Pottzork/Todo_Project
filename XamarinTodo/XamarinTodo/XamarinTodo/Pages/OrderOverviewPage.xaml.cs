﻿using System;
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
    public partial class OrderOverviewPage : ContentPage
    {
        public OrderOverviewPage()
        {
            InitializeComponent();
        }

        private async void OrderTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPendingPage());
        }

        public void temp()
        {
            JoinStuffThingy.Demo();
        }

        //Om OrderAccept = false så ska den visas här
        //Samt att OrderComplete är false.
        //Visa accepterade orders knutna till rätt OpId
    }
}