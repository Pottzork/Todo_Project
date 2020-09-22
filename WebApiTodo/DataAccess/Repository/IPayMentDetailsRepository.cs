using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IPayMentDetailsRepository
    {
        Task<IEnumerable<PayMentDetails>> GetPayMentDetails();
        Task<PayMentDetails> GetDetail(int id);
    }
}
