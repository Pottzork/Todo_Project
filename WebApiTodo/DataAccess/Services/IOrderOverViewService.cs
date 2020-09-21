using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IOrderOverViewService
    {
        Task<IEnumerable<OrderOverView>> GetOrderOverViews();
        Task<OrderOverView> GetOrderOverView(int id);
        Task<IEnumerable<OrderOverView>> GetListOfOrderOverViews(int id);
    }
}
