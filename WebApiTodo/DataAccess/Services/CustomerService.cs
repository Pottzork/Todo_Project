using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public async Task<bool> AddCustomer(Customers customer)
        {
            return await _customerRepository.AddCustomer(customer);
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            return await _customerRepository.DeleteCustomer(id);
        }

        public async Task<IEnumerable<Customers>> GetAllCustomers()
        {
            return await _customerRepository.GetAllCustomers();
        }

        public async Task<Customers> GetCustomer(int id)
        {
            return await _customerRepository.GetCustomer(id);
        }

        public async Task<bool> UpdateCustomer(Customers customer)
        {
            return await _customerRepository.UpdateCustomer(customer);
        }
    }
}