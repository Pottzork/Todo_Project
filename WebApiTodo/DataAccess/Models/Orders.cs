using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int OpId { get; set; }

        public string OrderDescription { get; set; }

        public string OrderResponse { get; set; }
        public bool OrderAccept { get; set; }

        public DateTime OrderEstTime { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }

        public bool OrderComplete { get; set; }
        public double OrderPrice { get; set; }

        public string OrderInfo { get; set; }
        
        
        

        
        public int CustomerCusId { get; set; }
        public int AddressId { get; set; }
    }
}
