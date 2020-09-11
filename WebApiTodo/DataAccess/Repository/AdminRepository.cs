using DataAccess.Models;
using System;
using System.Collections.Generic;
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
        public Task<Admin> AddAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Admin>> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public Task<Admin> UpdateAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
