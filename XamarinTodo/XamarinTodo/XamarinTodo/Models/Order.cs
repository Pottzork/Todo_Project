using System;
using System.Collections.Generic;
using System.Text;
using XamarinTodo.Pages;


namespace XamarinTodo.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        
        public string OrderResponse { get; set; }
        public bool OrderAccept { get; set; }
        public DateTime OrderEstTime { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public bool OrderComplete { get; set; }
        public float OrderPrice { get; set; }

        public int CusId { get; set; }


    }
}
