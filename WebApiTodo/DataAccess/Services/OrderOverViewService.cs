using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class OrderOverViewService : IOrderOverViewService
    {
        private readonly IOrderOverViewRepository _orderOverViewRepository;

        public OrderOverViewService(IOrderOverViewRepository orderOverViewRepository)
        {
            this._orderOverViewRepository = orderOverViewRepository;
        }

        public async Task<IEnumerable<OrderOverView>> GetListOfOrderOverViews(int id)
        {
            return await _orderOverViewRepository.GetListOfOrderOverViews(id);
        }

        public async Task<OrderOverView> GetOrderOverView(int id)
        {
            return await _orderOverViewRepository.GetOrderOverView(id);
        }

        public async Task<IEnumerable<OrderOverView>> GetOrderOverViews()
        {
            return await _orderOverViewRepository.GetOrderOverViews();
        }
    }
}
