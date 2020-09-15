using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace XamarinTodo.Models
{
    public class Customers
    {
        public int CusId { get; set; }
        public string CusInfo { get; set; }
        public string CusEmail { get; set; }
        public string CusPhone { get; set; }
        public string CusCompany { get; set; }
        public Addresss AdressId { get; set; }

    }
}
