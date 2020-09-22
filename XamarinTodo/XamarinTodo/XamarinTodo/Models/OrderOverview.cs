using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinTodo.Pages;

namespace XamarinTodo.Models
{
    public class OrderOverView
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public int OperatorID { get; set; }
        public DateTime OrderStart { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderEnd { get; set; }
        public int CustomerId { get; set; }
        public string OrderInfo { get; set; }

        [JsonIgnore]
        public string BgColor { get; set; }
    }
}