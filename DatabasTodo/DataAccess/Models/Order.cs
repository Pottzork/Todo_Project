using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Order
    {


        [Key]
        public int OrderId { get; set; }



        [Required]
        public string OrderDescription { get; set; }


        [Required]
        public string OrderResponse { get; set; }


        [Required]
        public bool OrderAccept { get; set; }


        public DateTime OrderEstTime { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime OrderStart { get; set; }

        public DateTime OrderEnd { get; set; }

        public bool OrderComplete { get; set; }


        public double OrderPrice { get; set; }


        public Customer Customer { get; set; }


        public Address Address { get; set; }


    }
}
