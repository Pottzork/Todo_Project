using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class HistoryOrderRepository : IHistoryOrderRepository
    {
        private readonly string _connectionString;

        public HistoryOrderRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public async Task<bool> AddHistoryOrder(OrderHistorys orderHistory)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("INSERT INTO OrderHistorys (OrderDescription, OrderResponse, OrderAccept, OrderStart, OrderEnd, OrderTime, OrderComplete, OrderPrice, OrderId) VALUES (@OrderDescription, @OrderResponse, @OrderAccept, @OrderStart, @OrderEnd, @OrderTime, @OrderComplete, @OrderPrice, @OrderId)",
                                        new { orderHistory.OrderDescription,
                                            orderHistory.OrderResponse,
                                            orderHistory.OrderAccept,
                                            orderHistory.OrderStart,
                                            orderHistory.OrderEnd,
                                            orderHistory.OrderTime,
                                            orderHistory.OrderComplete,
                                            orderHistory.OrderPrice,
                                            orderHistory.OrderId});
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    
                }
            }
        }

        public async Task<bool> DeleteHistoryOrder(int id)
        {
           using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("DELETE OrderHistorys WHERE OrderHistoryId = @Id", new { id });
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<IEnumerable<OrderHistorys>> GetAllHistoryOrders()
        {
            using(var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryAsync<OrderHistorys>("SELECT * FROM OrderHistorys");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<OrderHistorys> GetHistoryOrder(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                   return await c.QueryFirstOrDefaultAsync<OrderHistorys>("SELECT * FROM OrderHistorys WHERE OrderHistoryId = @Id", new { id });
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
