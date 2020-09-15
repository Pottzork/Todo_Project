using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorsController : Controller
    {
        private readonly IOperatorService _operatorService;

        public OperatorsController(IOperatorService operatorService)
        {
            this._operatorService = operatorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _operatorService.GetAllOperators());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _operatorService.GetOperator(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _operatorService.DeleteOperator(id));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Operators operators)
        {
            return Ok(await _operatorService.UpdateOperator(operators));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Operators operators)
        {
            return Ok(await _operatorService.AddOperator(operators));
        }
    }
}
