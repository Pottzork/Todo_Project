using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Admin
    {

        [Key]
        public int Id { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        public string UsertName { get; set; }


        [Required]
        public string Password { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [Phone]
        public string Phone { get; set; }



    }
}
