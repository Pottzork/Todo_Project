using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace XamarinTodo.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public string FullAddress (string Street, string PostalCode, string City)
        {
            
            string fullAddresss = ($"{Street}, {PostalCode}, {City}");
            return fullAddresss;
        }

        public int OrderID { get; set; }
    }
}