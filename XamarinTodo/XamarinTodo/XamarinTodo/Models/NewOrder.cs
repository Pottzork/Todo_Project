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


        public string company; //Cus
        public int orderId;   //Ord
        public string address; //Cus
        public string name;     //Cus
        public string phone;    //Cus
        public string orderDescription; //Ord
        public int Id; //Ope

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
