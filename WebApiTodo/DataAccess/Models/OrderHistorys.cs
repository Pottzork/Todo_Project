using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace DataAccess.Models
{
    public class OrderHistorys
    {
        public int OrderId { get; set; }
        public string Address { get; set; }
        public string OrderDescription { get; set; }
        public string OrderResponse { get; set; }

        public int OpId { get; set; }

        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public DateTime OrderTime { get; set; }
        public bool OrderComplete { get; set; }
        public double OrderPrice { get; set; }

    }
}
