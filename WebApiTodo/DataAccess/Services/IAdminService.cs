﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<Admins>> GetAllAdmins();
        Task<Admins> GetAdmin(int id);
        Task<Admins> AddAdmin(Admins admin);
        Task<Admins> UpdateAdmin(Admins admin);
        void DeleteAdmin(int id);
    }
}
