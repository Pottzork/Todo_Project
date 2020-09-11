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
        Task<bool> AddCustomer(Customers customer);
        Task<bool> UpdateCustomer(Customers customer);
        Task<bool> DeleteCustomer(int id);
    }
}
