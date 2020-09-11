using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customers>> GetAllCustomers();
        Task<Customers> GetCustomer(int id);
        Task<Customers> AddCustomer(Customers customer);
        Task<Customers> UpdateCustomer(Customers customer);
        void DeleteCustomer(int id);
    }
}
