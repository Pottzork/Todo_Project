using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class HistoryOrderService : IHistoryOrderService
    {
        private readonly IHistoryOrderRepository _historyOrderRepository;

        public HistoryOrderService(IHistoryOrderRepository historyOrderRepository)
        {
            this._historyOrderRepository = historyOrderRepository;
        }
        public async Task<bool> AddHistoryOrder(OrderHistorys orderHistory)
        {
            return await _historyOrderRepository.AddHistoryOrder(orderHistory);
        }

        public async Task<bool> DeleteHistoryOrder(int id)
        {
            return await _historyOrderRepository.DeleteHistoryOrder(id);
        }

        public async Task<IEnumerable<OrderHistorys>> GetAllHistoryOrders()
        {
            return await _historyOrderRepository.GetAllHistoryOrders();
        }

        public async Task<OrderHistorys> GetHistoryOrder(int id)
        {
            return await _historyOrderRepository.GetHistoryOrder(id);
        }
    }
}
