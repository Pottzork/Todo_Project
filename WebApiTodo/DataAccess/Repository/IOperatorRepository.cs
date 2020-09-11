using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOperatorRepository
    {
        Task<IEnumerable<WorkingOperator>> GetAllWorkingOperators();
        Task<WorkingOperator> GetWorkingOperator(int id);
        Task<WorkingOperator> AddWorkingOperator(WorkingOperator workingOperator);
        Task<WorkingOperator> UpdateWorkingOperator(WorkingOperator workingOperator);
        void DeleteWorkingOperator(int id);
    }
}
