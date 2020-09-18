using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly string _connectionString;

        public OrderRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public async Task<Orders> GetOrder(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryFirstOrDefaultAsync<Orders>("SELECT * FROM Orders WHERE OrderId = @id", new { id });
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<IEnumerable<Orders>> GetOrders()
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryAsync<Orders>("SELECT * FROM Orders");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public async Task<bool> AddOrder(Orders order)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("INSERT INTO Orders (OrderDescription, OrderAccept, OrderDate, OrderStart, OrderEnd, OrderComplete, OrderPrice, OrderInfo, CustomerId, OperatorID, PendingValue) VALUES (@OrderDescription, @OrderAccept, @OrderDate, @OrderStart, @OrderEnd, @OrderComplete, @OrderPrice, @OrderInfo, @CustomerId, @OperatorID, @PendingValue)",
                        new {order.OrderDescription, order.OrderAccept, order.OrderDate, order.OrderStart, order.OrderEnd, order.OrderComplete, order.OrderPrice, order.OrderInfo, order.CustomerId, order.OperatorID, order.PendingValue});

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateOrder(Orders order)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("UPDATE Orders SET OrderDescription = @OrderDescription, OrderAccept = @OrderAccept, OrderDate = @OrderDate, OrderStart = @OrderStart, OrderEnd = @OrderEnd, OrderComplete = @OrderComplete, OrderPrice = @OrderPrice, OrderInfo = @OrderInfo, CustomerId = @CustomerId, OperatorID = @OperatorID, PendingValue = @PendingValue WHERE OrderId = @OrderId",
                        new {order.OrderDescription, order.OrderAccept, order.OrderDate, order.OrderStart, order.OrderEnd, order.OrderComplete, order.OrderPrice, order.OrderInfo, order.CustomerId, order.OperatorID, order.PendingValue,  order.OrderId });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> DeleteOrder(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("DELETE Orders WHERE OrderId = @id", new { id });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }
    }
}
