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
        public async Task<bool> AddCustomer(Customers customer)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("INSERT INTO Customers (CusName, CusEmail, CusPhone, CusCompany, AddressId) VALUES (@CusName, @CusEmail, @CusPhone, @CusCompany, @AddressId)",
                        new { customer.CusName, customer.CusEmail, customer.CusPhone, customer.CusCompany, customer.AddressId });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("DELETE Customers WHERE CusId = @Id", new { id });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
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

        public async Task<bool> UpdateCustomer(Customers customer)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("UPDATE Customers SET CusName = @CusName, CusEmail = @CusEmail, CusPhone = @CusPhone, CusCompany = @CusCompany, AddressId = @AddressId WHERE CusId = @CusId",
                        new { customer.CusName, customer.CusEmail, customer.CusPhone, customer.CusCompany, customer.AddressId, customer.CusId });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
