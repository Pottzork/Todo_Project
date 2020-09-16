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
        public string Address { get; set; }
        public int OrderID { get; set; }
    }
}