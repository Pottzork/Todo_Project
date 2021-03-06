﻿using System;
using System.Collections.Generic;
using System.Text;
using XamarinTodo.Pages;

namespace XamarinTodo.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public float OrderPrice { get; set; }
        public string OrderInfo { get; set; }
        public int CustomerId { get; set; }
        public int OperatorId { get; set; }
        public string OrderDeclineReason { get; set; }
        public string OrderCompleteMessage { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}