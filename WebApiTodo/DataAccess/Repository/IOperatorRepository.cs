using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOperatorRepository
    {
        Task<IEnumerable<Operators>> GetAllWorkingOperators();
        Task<Operators> GetWorkingOperator(int id);
        Task<Operators> AddWorkingOperator(Operators workingOperator);
        Task<Operators> UpdateWorkingOperator(Operators workingOperator);
        void DeleteWorkingOperator(int id);
    }
}
