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
