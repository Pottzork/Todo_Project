using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public bool OrderAccept { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public bool OrderComplete { get; set; }
        public float OrderPrice { get; set; }
        public string OrderInfo { get; set; }
        public int CustomerId { get; set; }
        public int OperatorID { get; set; }
        public int PendingValue { get; set; } = 0;
    }
}
