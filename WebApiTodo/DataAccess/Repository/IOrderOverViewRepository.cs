using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderOverViewRepository
    {
        Task<IEnumerable<OrderOverView>> GetOrderOverViews();
        Task<OrderOverView> GetOrderOverView(int id);
        Task<IEnumerable<OrderOverView>> GetListOfOrderOverViews(int id);
    }
}
