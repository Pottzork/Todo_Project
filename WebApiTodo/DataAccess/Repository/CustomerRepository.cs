using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString;

        public CustomerRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public Task<bool> AddCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customers>> GetAllCustomers()
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryAsync<Customers>("SELECT * FROM Customers");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<Customers> GetCustomer(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryFirstOrDefaultAsync<Customers>("SELECT * FROM Customers WHERE CusId = @Id", new { id });
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public Task<Customers> UpdateCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }
    }
}
