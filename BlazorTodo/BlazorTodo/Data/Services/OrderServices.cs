using BlazorTodo.Data.Repositorys;
using BlazorTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo.Data.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepositorys orderRepo;

        public OrderServices(IOrderRepositorys orderRepo)
        {
            this.orderRepo = orderRepo;
        }
        public async Task<bool> AddOrder(Orders order)
        {
            return await orderRepo.AddOrder(order);
        }

        public async Task<bool> DeleteOrder(int id)
        {
            return await orderRepo.DeleteOrder(id);
        }

        public async Task<Orders> GetOrder(int id)
        {
            return await orderRepo.GetOrder(id);
        }

        public async Task<IEnumerable<Orders>> GetOrders()
        {
            return await orderRepo.GetOrders();
        }

        public async Task<bool> UpdateOrder(Orders order)
        {
            return await orderRepo.UpdateOrder(order);
        }
    }
}
