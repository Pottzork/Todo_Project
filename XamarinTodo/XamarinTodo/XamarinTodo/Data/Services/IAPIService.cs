using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public interface IAPIService
    {
        Task<List<OrderOverView>> GetOrderOverViewAsync(int operatorId);

        Task<Orders> GetOrderAsync(int orderId);

        Task UpdateOrderAsync(Object objectclass);
    }
}