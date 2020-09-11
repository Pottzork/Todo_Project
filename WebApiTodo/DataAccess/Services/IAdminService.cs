using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<Admin>> GetAllAdmins();
        Task<Admin> GetAdmin(int id);
        Task<Admin> AddAdmin(Admin admin);
        Task<Admin> UpdateAdmin(Admin admin);
        void DeleteAdmin(int id);
    }
}
