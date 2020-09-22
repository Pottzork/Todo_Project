using BlazorTodo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo.Data.Repositorys
{
    public class OrderRepository : IOrderRepositorys
    {
        private readonly string connectionString;

        public OrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public async Task<bool> AddOrder(Orders order)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Orders> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Orders>> GetOrders()
        {
            using (var c = new SqlConnection())
            {
                try
                {
                    return await c.
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<bool> UpdateOrder(Orders order)
        {
            throw new NotImplementedException();
        }
    }
}
