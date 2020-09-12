using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OperatorRepository : IOperatorRepository
    {
        public Task<Operators> AddWorkingOperator(Operators workingOperator)
        {
            throw new NotImplementedException();
        }

        public void DeleteWorkingOperator(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Operators>> GetAllWorkingOperators()
        {
            throw new NotImplementedException();
        }

        public Task<Operators> GetWorkingOperator(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Operators> UpdateWorkingOperator(Operators workingOperator)
        {
            throw new NotImplementedException();
        }
    }
}
