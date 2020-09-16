using System;
using System.Collections.Generic;
using System.Text;



namespace XamarinTodo.Models
{
    public class NewOrder
    {
        Customers customers = new Customers();
        Orders orders = new Orders();
        Operators operators = new Operators();


        private string company;

        public string Company
        {
            get { return customers.Company; }
            set { customers.Company = company; }
        }

        private int orderId;

        public int OrderId
        {
            get { return orders.OrderId; }
            set { orders.OrderId = orderId; }
        }

        private string address;

        public string Address
        {
            get { return customers.Address; }
            set { customers.Address = address; }
        }


        //public string Company { get; set; }
        //public int OrderId { get; set; }
        //public string Address { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string  OrderDescription { get; set; }



    }
}
