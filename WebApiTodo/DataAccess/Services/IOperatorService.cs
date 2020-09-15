using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IOperatorService
    {
        Task<IEnumerable<Operators>> GetAllOperators();
        Task<Operators> GetOperator(int id);
        Task<bool> AddOperator(Operators Operator);
        Task<bool> UpdateOperator(Operators Operator);
        Task<bool> DeleteOperator(int id);
    }
}
