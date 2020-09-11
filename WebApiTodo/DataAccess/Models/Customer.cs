using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Customer
    {
        public int CusId { get; set; }
        public string CusName { get; set; }
        public string Address { get; set; }
        public string CusInfo { get; set; }
        public string CusEmail { get; set; }
        public string CusPhone { get; set; }
        public string CusCompany { get; set; }
    }
}
