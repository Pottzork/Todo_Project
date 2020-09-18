using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IPayMentDetailsService
    {
        Task<IEnumerable<PayMentDetails>> GetPayMentDetails();
        Task<PayMentDetails> GetDetail(int id);
    }
}
