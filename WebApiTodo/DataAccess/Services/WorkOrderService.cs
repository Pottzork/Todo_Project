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
    public class WorkOrderService : IWorkOrderService
    {
        private readonly IWorkOrderRepository _workRepository;

        public WorkOrderService(IWorkOrderRepository workRepository)
        {
            this._workRepository = workRepository;
        }

        public async Task<Order> GetWorkOrder(int id)
        {
            return await _workRepository.GetWorkOrder(id);
        }

        public async Task<IEnumerable<Order>> GetWorkOrders()
        {
            return await _workRepository.GetWorkOrders();
        }
    }
}
