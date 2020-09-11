using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OperatorRepository : IOperatorRepository
    {
        public Task<WorkingOperator> AddWorkingOperator(WorkingOperator workingOperator)
        {
            throw new NotImplementedException();
        }

        public void DeleteWorkingOperator(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkingOperator>> GetAllWorkingOperators()
        {
            throw new NotImplementedException();
        }

        public Task<WorkingOperator> GetWorkingOperator(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WorkingOperator> UpdateWorkingOperator(WorkingOperator workingOperator)
        {
            throw new NotImplementedException();
        }
    }
}
