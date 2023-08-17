using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Concrete;
using HotelApi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly ServiceManager _serviceManager;

        public ServiceController(ServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Service service)
        {
            if (service == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _serviceManager.TInsert(service);
            return Ok();
        }
    }
}