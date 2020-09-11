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
