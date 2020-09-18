using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PayMentDetailsRepository : IPayMentDetailsRepository
    {
        private readonly string _connectionString;

        public PayMentDetailsRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public async Task<IEnumerable<PayMentDetails>> GetPayMentDetails()
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                return await c.QueryAsync<PayMentDetails>("SELECT * FROM PayMentDetails");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<PayMentDetails> GetDetail(int id)
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                return await c.QueryFirstOrDefaultAsync<PayMentDetails>("SELECT * FROM PayMentDetails WHERE OrderID = @id", new { id });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
