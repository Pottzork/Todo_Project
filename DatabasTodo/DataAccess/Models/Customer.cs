using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Customer
    {


        [Key]
        public int CusId { get; set; }

        [Required]
        public string CusName { get; set; }
        
        [Required]
        public string CusInfo { get; set; }

        [Required]
        public string CusEmail { get; set; }
        
        [Required]
        public string CusPhone { get; set; }


        public string CusCompany { get; set; }


        public Address Address { get; set; }

    }
}
