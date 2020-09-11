using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OperatorRepository : IOperatorRepository
    {
        public Task<Operator> AddWorkingOperator(Operator workingOperator)
        {
            throw new NotImplementedException();
        }

        public void DeleteWorkingOperator(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Operator>> GetAllWorkingOperators()
        {
            throw new NotImplementedException();
        }

        public Task<Operator> GetWorkingOperator(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Operator> UpdateWorkingOperator(Operator workingOperator)
        {
            throw new NotImplementedException();
        }
    }
}
