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

        public Task<Customer> AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}