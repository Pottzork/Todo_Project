using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTodo.Models
{
    class OrderOverview
    {
                public string Name { get; set; }
             public string Company { get; set; }
                public string Address { get; set; }  //Street, PostalCode, City

                public int OrderId { get; set; }

                public string OrderDescription { get; set; }
                public int OperatorID { get; set; }

                public DateTime OrderStart { get; set; }

        //Enum OrderStatus  INT, null
                public DateTime OrderEnd { get; set; }
        public int CustomerId { get; set; }

                public string OrderInfo { get; set; }
                public DateTime OrderEnd { get; set; }



    }
}
