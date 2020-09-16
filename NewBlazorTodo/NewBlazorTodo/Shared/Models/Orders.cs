﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public class Orders
    {
        public int orderId { get; set; }
        public string orderDescription { get; set; }
        public bool orderAccept { get; set; } = false;
        public DateTime orderDate { get; set; } = DateTime.Now;
        public DateTime orderStart { get; set; } = DateTime.Now;
        public DateTime orderEnd { get; set; } = DateTime.Now;
        public bool orderComplete { get; set; } = false;
        public float orderPrice { get; set; } = 0;
        public string orderInfo { get; set; }
        public int customerCusId { get; set; }

        public int OperatorID { get; set; }
    }
}