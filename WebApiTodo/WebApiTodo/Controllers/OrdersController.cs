using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderService _OrderService;

        public OrdersController(IOrderService OrderService)
        {
            this._OrderService = OrderService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _OrderService.GetOrders());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _OrderService.GetWorkOrder(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Orders Orders)
        {
            return Ok(await _OrderService.AddOrder(Orders));
        }
    }
}
