using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOperatorRepository
    {
        Task<IEnumerable<Operators>> GetAllOperators();
        Task<Operators> GetOperator(int id);
        Task<bool> AddOperator(Operators Operator);
        Task<bool> UpdateOperator(Operators Operator);
        Task<bool> DeleteOperator(int id);
    }
}
