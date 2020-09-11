using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            this._adminRepository = adminRepository;
        }

        public async Task<bool> AddAdmin(Admins admin)
        {
            return await _adminRepository.AddAdmin(admin);
        }

        public async Task<bool> DeleteAdmin(int id)
        {
            return await _adminRepository.DeleteAdmin(id);
        }

        public async Task<Admins> GetAdmin(int id)
        {
            return await _adminRepository.GetAdmin(id);
        }

        public async Task<IEnumerable<Admins>> GetAllAdmins()
        {
            return await _adminRepository.GetAllAdmins();
        }

        public async Task<bool> UpdateAdmin(Admins admin)
        {
            return await _adminRepository.UpdateAdmin(admin);
        }
    }
}
