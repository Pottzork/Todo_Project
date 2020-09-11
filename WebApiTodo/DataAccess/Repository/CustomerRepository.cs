using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerRepository(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
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
