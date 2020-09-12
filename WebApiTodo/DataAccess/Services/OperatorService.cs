using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class OperatorService : IOperatorService
    {
        private readonly IOperatorService _operatorService;

        public OperatorService(IOperatorService operatorService)
        {
            this._operatorService = operatorService;
        }

        public Task<Operators> AddWorkingOperator(Operators Operator)
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

        public Task<Operators> UpdateWorkingOperator(Operators Operator)
        {
            throw new NotImplementedException();
        }
    }
}
