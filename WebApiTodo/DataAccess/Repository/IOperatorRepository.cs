using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOperatorRepository
    {
        Task<IEnumerable<Operator>> GetAllWorkingOperators();
        Task<Operator> GetWorkingOperator(int id);
        Task<Operator> AddWorkingOperator(Operator workingOperator);
        Task<Operator> UpdateWorkingOperator(Operator workingOperator);
        void DeleteWorkingOperator(int id);
    }
}
