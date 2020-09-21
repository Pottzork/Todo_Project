using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return Ok(await _orderOverViewService.GetOrderOverView(id));
        //}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _orderOverViewService.GetOrderOverViews());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _orderOverViewService.GetListOfOrderOverViews(id));
        }
    }
}
