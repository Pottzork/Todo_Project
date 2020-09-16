using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Experience { get; set; }
    }
}
