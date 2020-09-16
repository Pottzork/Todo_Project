using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTodo.Models
{
    internal class OrderHistorys
    {
        public int OrderHistoryId { get; set; }
        public string OrderDescription { get; set; }
        public string OrderResponse { get; set; }
        public bool OrderAccept { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public DateTime OrderTime { get; set; }
        public bool OrderComplete { get; set; }
        public float OrderPrice { get; set; }
        public int OrderId { get; set; }
    }
}