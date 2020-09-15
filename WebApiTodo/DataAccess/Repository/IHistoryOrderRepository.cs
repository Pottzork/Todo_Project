using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IHistoryOrderRepository
    {
        Task<IEnumerable<OrderHistorys>> GetAllHistoryOrders();
        Task<OrderHistorys> GetHistoryOrder(int id);
        Task<bool> AddHistoryOrder(OrderHistorys orderHistory);
        Task<bool> DeleteHistoryOrder(int id);
    }
}
