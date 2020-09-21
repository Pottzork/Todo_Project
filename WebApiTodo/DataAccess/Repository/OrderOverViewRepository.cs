using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderOverViewRepository : IOrderOverViewRepository
    {
        private readonly string _connectionString;

        public OrderOverViewRepository(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        public async Task<IEnumerable<OrderOverView>> GetListOfOrderOverViews(int id)
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                return await c.QueryAsync<OrderOverView>("SELECT * FROM OrderOverView WHERE OperatorID = @id", new { id });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OrderOverView> GetOrderOverView(int id)
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                return await c.QueryFirstOrDefaultAsync<OrderOverView>("SELECT * FROM OrderOverView WHERE OperatorID = @id", new { id });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<OrderOverView>> GetOrderOverViews()
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                return await c.QueryAsync<OrderOverView>("SELECT * FROM OrderOverView");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
