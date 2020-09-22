using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo.Models
{
    public class Orders
    {
        public int orderId { get; set; }
        public int opId { get; set; }
        public string orderDescription { get; set; }
        public string orderResponse { get; set; }
        public bool orderAccept { get; set; }
        public DateTime orderEstTime { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime orderStart { get; set; }
        public DateTime orderEnd { get; set; }
        public bool orderComplete { get; set; }
        public int orderPrice { get; set; }
        public string orderInfo { get; set; }
        public int customerCusId { get; set; }
        public int addressId { get; set; }
    }
}
