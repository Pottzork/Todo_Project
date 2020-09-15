using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderHistoryController : Controller
    {
        private readonly IHistoryOrderService _historyOrderService;

        public OrderHistoryController(IHistoryOrderService historyOrderService)
        {
            this._historyOrderService = historyOrderService;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _historyOrderService.GetHistoryOrder(id));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _historyOrderService.GetAllHistoryOrders());
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrderHistorys orderHistory)
        {
            return Ok(await _historyOrderService.AddHistoryOrder(orderHistory));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _historyOrderService.DeleteHistoryOrder(id));
        }
    }
}
