using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetOrdersAsync();

        Task<bool> UpdateOrderAsync(T item);
    }
}