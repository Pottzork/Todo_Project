using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Addresss
    {
        public int AdressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
