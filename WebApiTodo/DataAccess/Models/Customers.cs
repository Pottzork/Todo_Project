﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Customers
    {
        public int CusId { get; set; }
        public string CusName { get; set; }
        public string CusEmail { get; set; }
        public string CusPhone { get; set; }
        public string CusCompany { get; set; }
        public int AddressId { get; set; }
    }
}
