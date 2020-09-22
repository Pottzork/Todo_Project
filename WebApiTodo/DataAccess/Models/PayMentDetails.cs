using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class PayMentDetails
    {
        public int Id { get; set; }
        public string OrderDescription { get; set; }
        public string OrderStart { get; set; }
        public string OrderEnd { get; set; }
        public string Company { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public float OrderPrice { get; set; }
        public bool OrderComplete { get; set; }

    }
}
