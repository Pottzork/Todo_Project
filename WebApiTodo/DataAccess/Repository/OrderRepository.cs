﻿using Dapper;
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


        async Task<bool> IOrderRepository.AddOrder(Orders order)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("INSERT INTO Orders (OrderId, OrderDescription, OrderResponse, OrderAccept, OrderEstTime, OrderDate, OrderStart, OrderEnd, OrderComplete, OrderPrice, OrderInfo, CustomerCusId, AddressId) VALUES (@OrderId, @OrderDescription, @OrderResponse, @OrderAccept, @OrderEstTime, @OrderDate, @OrderStart, @OrderEnd, @OrderComplete, @OrderPrice, @OrderInfo, @CustomerCusId, @AddressId)",
                        new { order.OrderId, order.OrderDescription, order.OrderResponse, order.OrderAccept, order.OrderEstTime, order.OrderDate, order.OrderStart, order.OrderEnd, order.OrderComplete, order.OrderPrice, order.OrderInfo, order.CustomerCusId, order.AddressId });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
