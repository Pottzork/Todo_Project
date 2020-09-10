using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    public class WorkOrder
    {
        public int WorkOrderId { get; set; }
        public DateTime WorkOrderDate { get; set; }
        public string WorkOrderDescription { get; set; }
        public string WorkOrderAddress { get; set; }
        public string WorkOrderPhoneNumber { get; set; }
        public string WorkOrderContactName { get; set; }
    }
}
