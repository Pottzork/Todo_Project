using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Orders>> GetOrders();
        Task<Orders> GetOrder(int id);
    }
}
