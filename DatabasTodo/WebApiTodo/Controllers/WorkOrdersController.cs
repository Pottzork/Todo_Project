//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using DataAccess.Services;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApiTodo.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class WorkOrdersController : Controller
//    {
//        private readonly IWorkOrderService _workOrderService;

//        public WorkOrdersController(IWorkOrderService workOrderService)
//        {
//            this._workOrderService = workOrderService;
//        }

//        [HttpGet]
//        public async Task<IActionResult> Get()
//        {
//            return Ok(await _workOrderService.GetWorkOrders());
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> Get(int id)
//        {
//            return Ok(await _workOrderService.GetWorkOrder(id));
//        }
//    }
//}
