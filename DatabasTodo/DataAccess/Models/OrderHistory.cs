using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class OrderHistory
    {


        [Key]
        public int OrderId { get; set; }



        [Required]
        public string OrderDescription { get; set; }


        [Required]
        public string OrderResponse { get; set; }


        [Required]
        public bool OrderAccept { get; set; }


        public DateTime OrderStart { get; set; }

        public DateTime OrderEnd { get; set; }
        public DateTime OrderTime { get; set; }

        [Required]
        public bool OrderComplete { get; set; }


        [Required]
        public double OrderPrice { get; set; }

        public Order Order { get; set; }


        [Required]
        public Address Address { get; set; }

    }
}
