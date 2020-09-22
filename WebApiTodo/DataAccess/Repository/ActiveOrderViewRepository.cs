using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ActiveOrderViewRepository : IActiveOrderViewRepository
    {
        private readonly string _connectionString;

        public ActiveOrderViewRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public async Task<IEnumerable<ActiveOrderView>> GetAllActiveOrderViews()
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                  return await c.QueryAsync<ActiveOrderView>("SELECT * FROM ActiveOrderView");
                    
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async Task<ActiveOrderView> GetFaktura(int id)
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                return await c.QueryFirstOrDefaultAsync<ActiveOrderView>("SELECT * FROM ActiveOrderView WHERE OrderId = @id", new { id });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
