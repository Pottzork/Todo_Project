using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string Address { get; set; }
        public string CusInfo { get; set; }
        public string OrderDescription { get; set; }
        public string OrderResponse { get; set; }
        public bool OrderAccept { get; set; } = false;
        public int OpId { get; set; }


        public DateTime OrderEstTime { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public DateTime OrderTime { get; set; }

        public bool OrderComplete { get; set; } = false;
        public double OrderPrice { get; set; } = 0;
        public int CustomerCusId { get; set; }
        public int AddressId { get; set; }
    }
}
