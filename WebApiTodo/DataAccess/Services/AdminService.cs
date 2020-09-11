using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminService _adminService;

        public AdminService(IAdminService adminService)
        {
            this._adminService = adminService;
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
