﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IAddressService
    {
        Task<IEnumerable<Addresss>> GetAddresses();
        Task<Addresss> GetAddress(int id);
        //Task<Addresss> SearchAddress(string name); 
        Task<bool> AddAddress(Addresss address);
        Task<bool> UpdateAddress(Addresss address);
        Task<bool> DeleteAddress(int id);
    }
}