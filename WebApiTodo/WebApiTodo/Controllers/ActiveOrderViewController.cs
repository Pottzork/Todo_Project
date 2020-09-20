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
    public class ActiveOrderViewController : Controller
    {
        private readonly IActiveOrderViewService _activeOrderViewService;

        public ActiveOrderViewController(IActiveOrderViewService activeOrderViewService)
        {
            this._activeOrderViewService = activeOrderViewService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           return Ok(await _activeOrderViewService.GetAllActiveOrderViews());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _activeOrderViewService.GetFaktura(id));
        }
    }
}
