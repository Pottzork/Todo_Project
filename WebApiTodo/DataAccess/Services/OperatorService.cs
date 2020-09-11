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
