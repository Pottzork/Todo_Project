using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Address { get; set; }
        public string CusInfo { get; set; }
        public string OrderDescription { get; set; }
        public string OrderResponse { get; set; }
        public string OrderAccept { get; set; }
        public int OpId { get; set; }


        public DateTime OrderEstTime { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public DateTime OrderTime { get; set; }

        public bool OrderComplete { get; set; }
        public double OrderPrice { get; set; }
    }
}
