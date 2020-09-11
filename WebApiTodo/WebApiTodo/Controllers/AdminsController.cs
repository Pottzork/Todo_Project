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
    public class AdminsController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminsController(IAdminService adminService)
        {
            this._adminService = adminService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _adminService.GetAllAdmins());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _adminService.GetAdmin(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Admins admins)
        {
            return Ok(await _adminService.AddAdmin(admins));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _adminService.DeleteAdmin(id));
        }
    }
}
