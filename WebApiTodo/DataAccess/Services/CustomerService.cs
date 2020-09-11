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

        public Task<Customers> AddCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customers>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customers> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customers> UpdateCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }
    }
}