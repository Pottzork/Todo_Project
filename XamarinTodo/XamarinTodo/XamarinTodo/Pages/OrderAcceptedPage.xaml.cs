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
    public partial class OrderAcceptedPage : ContentPage
    {
        public IAPIService Service => DependencyService.Get<IAPIService>();

        private OrderOverView _orderOverView;
        private Orders _order;

        public OrderAcceptedPage(OrderOverView orderOverView)
        {
            _orderOverView = new OrderOverView();
            _orderOverView = orderOverView;

            InitializeComponent();

            LabelCustomerName.Text = _orderOverView.Company;
            LabelCustomerId.Text = _orderOverView.OrderId.ToString();
            LabelAdress.Text = _orderOverView.Street;
            LabelContactPerson.Text = _orderOverView.Name;
            LabelOrderDescription.Text = _orderOverView.OrderDescription;
        }

        private async void AddInfoSwipe_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDoneAddInfoPage(_orderOverView));
        }

        private async void MarkAsPendingSwipe_Invoked(object sender, EventArgs e)
        {
            bool displayAlertAnswer = await DisplayAlert("Alert", "Är du säker på att du vill markera order som ej accepterad?", "Ja!", "Nej.");

            if (displayAlertAnswer)
            {
                _order = await Service.GetOrderAsync(_orderOverView.OrderId);

                _order.OrderStatus = OrderStatus.EJ_ACCEPTERAD;
                await Service.UpdateOrderAsync(_order);

                DependencyService.Get<IToastMessage>().LongAlert("Order ej längre accepterad");

                await Navigation.PushAsync(new OrderOverviewPage());
            }
        }
    }
}