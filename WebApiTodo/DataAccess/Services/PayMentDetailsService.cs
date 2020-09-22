using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class PayMentDetailsService : IPayMentDetailsService
    {
        private readonly IPayMentDetailsRepository _payMentDetailsRepository;

        public PayMentDetailsService(IPayMentDetailsRepository payMentDetailsRepository)
        {
            this._payMentDetailsRepository = payMentDetailsRepository;
        }

        public async Task<PayMentDetails> GetDetail(int id)
        {
            return await _payMentDetailsRepository.GetDetail(id);
        }

        public async Task<IEnumerable<PayMentDetails>> GetPayMentDetails()
        {
            return await _payMentDetailsRepository.GetPayMentDetails();
        }
    }
}
