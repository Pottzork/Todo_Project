using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public class DataService : IDataService<Orders>
    {
        private readonly List<Orders> orders;

        public DataService()
        {
            orders = new List<Orders>()
            {
                new Orders{ OrderId = 0, OrderDescription="Fixa elkoppling", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="Dörr på baksidan", CustomerCusId=1, OperatorID=1},
                new Orders{ OrderId = 1, OrderDescription="Trasigt kylskåp", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="Andra våningen", CustomerCusId=1, OperatorID=1},
                new Orders{ OrderId = 2, OrderDescription="Trasig eskalator", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="", CustomerCusId=1, OperatorID=1},
                new Orders{ OrderId = 3, OrderDescription="Trasigt kylskåp", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="Andra våningen", CustomerCusId=1, OperatorID=1}
            };
        }

        public async Task<IEnumerable<Orders>> GetItemsAsync()
        {
            return await Task.FromResult(orders);
        }
    }
}