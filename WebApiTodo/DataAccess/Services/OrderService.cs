using Dapper;
using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public async Task<Orders> GetWorkOrder(int id)
        {
            return await _orderRepository.GetOrder(id);
        }

        public async Task<IEnumerable<Orders>> GetOrders()
        {
            return await _orderRepository.GetOrders();
        }

        public async Task<bool> AddOrder(Orders order)
        {
            return await _orderRepository.AddOrder(order);
        }
    }
}
