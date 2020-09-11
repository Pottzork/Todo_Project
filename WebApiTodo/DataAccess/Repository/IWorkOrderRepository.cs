using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IWorkOrderRepository
    {
        Task<IEnumerable<Order>> GetWorkOrders();
        Task<Order> GetWorkOrder(int id);
    }
}
