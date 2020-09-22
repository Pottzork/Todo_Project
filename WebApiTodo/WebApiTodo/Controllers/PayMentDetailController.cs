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
    public class PayMentDetailController : Controller
    {
        private readonly IPayMentDetailsService _payMentDetailService;

        public PayMentDetailController(IPayMentDetailsService payMentDetailService)
        {
            this._payMentDetailService = payMentDetailService;
        }

        [HttpGet]
        public async Task<IEnumerable<PayMentDetails>> Get()
        {
            return await _payMentDetailService.GetPayMentDetails();
        }

        [HttpGet("{id}")]
        public async Task<PayMentDetails> Get(int id)
        {
            return await _payMentDetailService.GetDetail(id);
        }
    }
}
