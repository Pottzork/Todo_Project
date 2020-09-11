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
        public Task<Admins> AddAdmin(Admins admin)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Admins> GetAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Admins>> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public Task<Admins> UpdateAdmin(Admins admin)
        {
            throw new NotImplementedException();
        }
    }
}
