using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace XamarinTodo.Models
{
    class NewOrder
    {

        Customers customers = new Customers();
        Orders orders = new Orders();
        Operators operators = new Operators();

        Array[] newOrder;

        public string company;
        public int orderId;
        public string address;
        public string name;
        public string phone;
        public string orderDescription;

        public NewOrder(string Company, int OrderId, string Address, string Name, string Phone, string OrderDescription)
        {
            company = Company;
            orderId = OrderId;
            address = Address;
            name = Name;
            phone = Phone;
            orderDescription = OrderDescription;


        }



    }
}
