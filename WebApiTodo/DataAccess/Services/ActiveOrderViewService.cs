using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class ActiveOrderViewService : IActiveOrderViewService
    {
        private readonly IActiveOrderViewRepository _activeOrderViewRepository;

        public ActiveOrderViewService(IActiveOrderViewRepository activeOrderViewRepository)
        {
            this._activeOrderViewRepository = activeOrderViewRepository;
        }
        public async Task<IEnumerable<ActiveOrderView>> GetAllActiveOrderViews()
        {
            return await _activeOrderViewRepository.GetAllActiveOrderViews();
        }
    }
}
