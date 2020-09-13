using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            this._addressRepository = addressRepository;
        }
        public async Task<bool> AddAddress(Addresss address)
        {
            return await _addressRepository.AddAddress(address);
        }

        public async Task<bool> DeleteAddress(int id)
        {
            return await _addressRepository.DeleteAddress(id);
        }

        public async Task<Addresss> GetAddress(int id)
        {
            return await _addressRepository.GetAddress(id);
        }

        public async Task<IEnumerable<Addresss>> GetAddresses()
        {
            return await _addressRepository.GetAddresses();
        }

        public async Task<bool> UpdateAddress(Addresss address)
        {
            return await _addressRepository.UpdateAddress(address);
        }
    }
}
