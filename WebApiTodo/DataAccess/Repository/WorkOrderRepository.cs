using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class WorkOrderRepository : IWorkOrderRepository
    {
        private readonly string _connectionString;

        public WorkOrderRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public async Task<WorkOrder> GetWorkOrder(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryFirstOrDefaultAsync<WorkOrder>("SELECT * FROM WorkOrders WHERE WorkOrderId = @id", new { id });
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<IEnumerable<WorkOrder>> GetWorkOrders()
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryAsync<WorkOrder>("SELECT * FROM WorkOrders");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
