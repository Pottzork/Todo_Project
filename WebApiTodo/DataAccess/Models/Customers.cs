using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public int OrderId { get; set; }
    }
}
