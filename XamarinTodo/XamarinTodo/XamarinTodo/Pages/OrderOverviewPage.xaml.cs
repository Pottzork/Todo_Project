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
        public IAPIService Service => DependencyService.Get<IAPIService>();

        private List<OrderOverView> _orderOverViewList;
        private OrderOverView _orderOverView;
        private List<OrderOverView> _selectedOrderList;

        public int OperatorId { get; set; } = 27;

        public OrderOverviewPage()
        {
            InitializeComponent();
            GetOrders();
            orderOverviewList.ItemsSource = _orderOverViewList;
            SetBgColor();
        }

        private async void GetOrders()
        {
            _selectedOrderList = new List<OrderOverView>();
            var allOrdersList = await Service.GetOrderOverViewAsync(OperatorId);

            foreach (var order in allOrdersList)
            {
                if (order.OrderStatus == OrderStatus.ACCEPTERAD || order.OrderStatus == OrderStatus.EJ_ACCEPTERAD)
                {
                    _selectedOrderList.Add(order);
                }
            }

            _orderOverViewList = SortOrders(_selectedOrderList).ToList();
        }

        private void SetBgColor()
        {
            foreach (var order in _orderOverViewList)
            {
                if (order.OrderStatus == OrderStatus.EJ_ACCEPTERAD) //Ska ändras till Orderstatus.EJ_ACCEPTERAD
                {
                    order.BgColor = "#FFFF00";
                }
                else if (order.OrderStatus == OrderStatus.ACCEPTERAD) //Ska ändras till Orderstatus.ACCEPTERAD
                {
                    order.BgColor = "#00ff00";
                }
                else
                {
                    order.BgColor = "#FFF";
                }
            }
        }

        private async void orderOverviewList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _orderOverView = e.CurrentSelection[0] as OrderOverView;

            if (_orderOverView.OrderStatus == OrderStatus.ACCEPTERAD)
            {
                await Navigation.PushAsync(new OrderAcceptedPage(e.CurrentSelection[0] as OrderOverView));
            }
            else if (_orderOverView.OrderStatus == OrderStatus.EJ_ACCEPTERAD)
            {
                await Navigation.PushAsync(new OrderPendingPage(e.CurrentSelection[0] as OrderOverView));
            }
        }

        public IEnumerable<OrderOverView> SortOrders(List<OrderOverView> orders)
        {
            var sortedOrders = orders.OrderBy(x => x.OrderStart.Date)
                .ThenBy(x => x.OrderStart.TimeOfDay);

            return sortedOrders;
        }

        //public void temp()
        //{
        //    JoinStuffThingy.Demo();
        //}

        //Om OrderAccept = false så ska den visas här
        //Samt att OrderComplete är false.
        //Visa accepterade orders knutna till rätt OpId
    }
}