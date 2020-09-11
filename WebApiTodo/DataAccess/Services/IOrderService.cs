using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Orders>> GetWorkOrders();
        Task<Orders> GetWorkOrder(int id);
    }
}
