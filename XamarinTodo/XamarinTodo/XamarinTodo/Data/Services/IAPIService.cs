using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public interface IAPIService<T>
    {
        Task<List<T>> GetOrderOverViewAsync(int operatorId);
    }
}