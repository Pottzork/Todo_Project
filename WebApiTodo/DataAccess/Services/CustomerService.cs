using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerService _customerService;

        public CustomerService(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        public async Task<bool> AddCustomer(Customers customer)
        {
            return await _customerService.AddCustomer(customer);
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            return await _customerService.DeleteCustomer(id);
        }

        public async Task<IEnumerable<Customers>> GetAllCustomers()
        {
            return await _customerService.GetAllCustomers();
        }

        public async Task<Customers> GetCustomer(int id)
        {
            return await _customerService.GetCustomer(id);
        }

        public async Task<Customers> UpdateCustomer(Customers customer)
        {
            return await _customerService.UpdateCustomer(customer);
        }
    }
}