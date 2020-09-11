using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        

        [Required]
        public string Street { get; set; }
        
        [Required]
        public string City { get; set; }
        
        
        [Required]
        public string PostalCode { get; set; }
        
        
        [Required]
        public string Country { get; set; }



    }
}
