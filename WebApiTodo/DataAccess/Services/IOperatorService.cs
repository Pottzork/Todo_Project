using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public interface IOperatorService
    {
        Task<IEnumerable<Operators>> GetAllWorkingOperators();
        Task<Operators> GetWorkingOperator(int id);
        Task<Operators> AddWorkingOperator(Operators Operator);
        Task<Operators> UpdateWorkingOperator(Operators Operator);
        void DeleteWorkingOperator(int id);
    }
}
