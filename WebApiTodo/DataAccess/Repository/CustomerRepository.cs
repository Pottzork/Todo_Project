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
            using var c = new SqlConnection(_connectionString);
            try
            {
                await c.ExecuteAsync("INSERT INTO Customers (Name, Email, Phone, Company, Street, PostalCode, City, OrderID) VALUES (@Name, @Email, @Phone, @Company, @Street, @PostalCode, @City, @OrderID)",
                    new { customer.Name, customer.Email, customer.Phone, customer.Company, customer.Street, customer.PostalCode, customer.City, customer.OrderId });

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                await c.ExecuteAsync("DELETE Customers WHERE ID = @id", new { id });

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public async Task<IEnumerable<Customers>> GetAllCustomers()
        {
            using var c = new SqlConnection(_connectionString);
            try
            {
                return await c.QueryAsync<Customers>("SELECT * FROM Customers");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Customers> GetCustomer(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryFirstOrDefaultAsync<Customers>("SELECT * FROM Customers WHERE Id = @Id", new { id });
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
                    await c.ExecuteAsync("UPDATE Customers SET Name = @Name, Email = @Email, Phone = @Phone, Company = @Company, Street = @Street, PostalCode = @PostalCode, City = @City, OrderID = @OrderID WHERE Id = @Id",
                        new { customer.Name, customer.Email, customer.Phone, customer.Company, customer.Street, customer.PostalCode, customer.City, customer.OrderId, customer.Id });

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
