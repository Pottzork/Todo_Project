using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Addresss>> GetAddresses();
        Task<Addresss> GetAddress(int id);
        Task<bool> AddAddress(Addresss address);
        Task<bool> UpdateAddress(Addresss address);
        Task<bool> DeleteAddress(int id);
    }
}
