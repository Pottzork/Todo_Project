using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Customer email is required.")]
        public string  Email { get; set; }

        [Required(ErrorMessage = "Customer PhoneNumber is required.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Customers CompanyName is required.")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Customers StreetAddress is required.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Customers PostalCode is required.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Customers City is required.")]
        public string City { get; set; }

        public int OrderID { get; set; }

    }
}
