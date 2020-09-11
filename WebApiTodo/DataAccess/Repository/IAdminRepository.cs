using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
   public interface IAdminRepository
    {
        Task<IEnumerable<Admins>> GetAllAdmins();
        Task<Admins> GetAdmin(int id);
        Task<bool> AddAdmin(Admins admin);
        Task<Admins> UpdateAdmin(Admins admin);
        Task<bool> DeleteAdmin(int id);
    }
}
