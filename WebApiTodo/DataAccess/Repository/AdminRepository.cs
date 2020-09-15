using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly string _connectionString;

        public AdminRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public async Task<bool> AddAdmin(Admins admin)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("INSERT INTO Admins (UserName, Password, FirstName, LastName, Email, Phone) VALUES (@UserName, @Password, @FirstName, @LastName, @Email, @Phone)",
                        new { admin.UserName, admin.Password, admin.FirstName, admin.LastName, admin.Email, admin.Phone });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> DeleteAdmin(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("DELETE Admins WHERE ID = @id", new { id });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public async Task<Admins> GetAdmin(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryFirstOrDefaultAsync<Admins>("SELECT * FROM Admins WHERE ID = @id", new { id });
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<IEnumerable<Admins>> GetAllAdmins()
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryAsync<Admins>("SELECT * FROM Admins");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<bool> UpdateAdmin(Admins admin)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("UPDATE Admins SET UserName = @UserName, Password = @Password, FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone WHERE ID = @id",
                        new { admin.UserName, admin.Password, admin.FirstName, admin.LastName, admin.Email, admin.Phone, admin.Id });

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
