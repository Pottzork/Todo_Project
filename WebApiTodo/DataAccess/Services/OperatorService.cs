using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class OperatorService : IOperatorService
    {
        private readonly IOperatorRepository _operatorRepository;

        public OperatorService(IOperatorRepository operatorRepository)
        {
            this._operatorRepository = operatorRepository;
        }
        public async Task<bool> AddOperator(Operators Operator)
        {
            return await _operatorRepository.AddOperator(Operator);
        }

        public async Task<bool> DeleteOperator(int id)
        {
            return await _operatorRepository.DeleteOperator(id);
        }

        public async Task<IEnumerable<Operators>> GetAllOperators()
        {
            return await _operatorRepository.GetAllOperators();
        }

        public async Task<Operators> GetOperator(int id)
        {
            return await _operatorRepository.GetOperator(id);
        }

        public async Task<bool> UpdateOperator(Operators Operator)
        {
            return await _operatorRepository.UpdateOperator(Operator);
        }
    }
}
