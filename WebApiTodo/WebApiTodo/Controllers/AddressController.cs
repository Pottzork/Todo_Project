using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace WebApiTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            this._addressService = addressService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _addressService.GetAddresses());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _addressService.GetAddress(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Addresss address)
        {
            return Ok(await _addressService.AddAddress(address));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _addressService.DeleteAddress(id));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Addresss address)
        {
            return Ok(await _addressService.UpdateAddress(address));
        }
    }
}
