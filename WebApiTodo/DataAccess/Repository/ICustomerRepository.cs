using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customers>> GetAllCustomers();
        Task<Customers> GetCustomer(int id);
        Task<Customers> AddCustomer(Customers customer);
        Task<Customers> UpdateCustomer(Customers customer);
        void DeleteCustomer(int id);
    }
}
