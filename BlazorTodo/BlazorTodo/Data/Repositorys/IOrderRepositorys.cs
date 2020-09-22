using BlazorTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo.Data.Repositorys
{
    public interface IOrderRepositorys
    {
        Task<IEnumerable<Orders>> GetOrders();
        Task<Orders> GetOrder(int id);
        Task<bool> AddOrder(Orders order);
        Task<bool> UpdateOrder(Orders order);
        Task<bool> DeleteOrder(int id);
    }
}
