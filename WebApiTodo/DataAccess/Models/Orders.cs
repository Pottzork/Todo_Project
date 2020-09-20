using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Orders
    {
        public int OrderId { get; set; } = 0;
        public string OrderDescription { get; set; } = "";
        public bool OrderAccept { get; set; } = false;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime OrderStart { get; set; } = DateTime.Now;
        public DateTime OrderEnd { get; set; } = DateTime.Now;
        public bool OrderComplete { get; set; } = false;
        public float OrderPrice { get; set; } = 0;
        public string OrderInfo { get; set; } = "";
        public int CustomerId { get; set; } = 0;
        public int OperatorID { get; set; } = 0;
        public int PendingValue { get; set; } = 0;
    }
}
