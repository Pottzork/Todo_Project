using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace WebApiTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderOverViewController : Controller
    {
        private readonly IOrderOverViewService _orderOverViewService;

        public OrderOverViewController(IOrderOverViewService orderOverViewService)
        {
            this._orderOverViewService = orderOverViewService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            return Ok(await _orderOverViewService.SearchByName(name));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _orderOverViewService.GetOrderOverViews());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _orderOverViewService.GetListOfOrderOverViews(id));
        }
    }
}
