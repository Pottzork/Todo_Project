using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Orders
    {
        public int OrderId { get; set; } = 0;
        public string OrderDescription { get; set; } = "";
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime OrderStart { get; set; } = DateTime.Now;
        public DateTime OrderEnd { get; set; } = DateTime.Now;
        public float OrderPrice { get; set; } = 0;
        public string OrderInfo { get; set; } = "";
        public int CustomerId { get; set; } = 0;
        public int OperatorID { get; set; } = 0;
        public OrderStatus Orderstatus { get; set; } = OrderStatus.EJ_ACCEPTERAD;
        public string OrderDeclineReason { get; set; } = "";
        public string OrderCompleteMessage { get; set; } = "";
    }
}
