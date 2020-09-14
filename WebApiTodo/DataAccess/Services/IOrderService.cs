using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Orders>> GetOrders();
        Task<Orders> GetWorkOrder(int id);
        Task<bool> AddOrder(Orders order);
        Task<bool> UpdateOrder(Orders order);
        Task<bool> DeleteOrder(int id);
    }
}
