using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public class ActiveOrderView
    {
        public int OrderID { get; set; }
        public string OpFirstName { get; set; }
        public string OpLastName { get; set; }
        public string OrderDescription { get; set; }
        public DateTime OrderStart { get; set; }
        public string OrderInfo { get; set; }
        public string Customer { get; set; }
        public bool OrderComplete { get; set; }
    }
}
