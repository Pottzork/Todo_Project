using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinTodo.Pages;

namespace XamarinTodo.Models
{
    public class OrderOverView
    {
        //private DateTime _orderStart;

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

        //public DateTime OrderStart
        //{
        //    get { return _orderStart; }
        //    set { _orderStart.ToString("yyyy-MM-dd hh-mm"); }
        //}
        public OrderStatus OrderStatus { get; set; }

        public DateTime OrderEnd { get; set; }
        public int CustomerId { get; set; }
        public string OrderInfo { get; set; }

        //Lokala Props
        public string BgColor { get; set; }

        public string TextColor { get; set; }

        public string FullAdress => Street + ", " + PostalCode + " " + City;
    }
}