using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IActiveOrderViewRepository
    {
        Task<IEnumerable<ActiveOrderView>> GetAllActiveOrderViews();
    }
}
