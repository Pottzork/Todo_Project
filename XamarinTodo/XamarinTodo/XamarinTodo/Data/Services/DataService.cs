using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public class DataService : IDataService<Orders>
    {
        private MockDatabase mockDb;

        public DataService()
        {
            mockDb = new MockDatabase();
        }

        public async Task<IEnumerable<Orders>> GetOrdersAsync()
        {
            return mockDb.ListOfOrders;
        }

        public async Task<bool> UpdateOrderAsync(Orders order)
        {
            var oldOrder = mockDb.ListOfOrders.Where((Orders arg) => arg.OrderId == order.OrderId).FirstOrDefault();
            mockDb.ListOfOrders.Remove(oldOrder);
            mockDb.ListOfOrders.Add(order);

            return await Task.FromResult(true);
        }
    }
}