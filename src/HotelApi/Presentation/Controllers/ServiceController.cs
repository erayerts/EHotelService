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
    [Route("api/v1/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly ServiceManager _serviceManager;

        public ServiceController(ServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            Service resultObj = _serviceManager.TGetById(id);

            return Ok(resultObj);
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            List<Service> resultList = _serviceManager.TGetList();

            return Ok(resultList);
        }


        [HttpPost("insert")]
        public IActionResult Post([FromBody] Service service)
        {
            if (service == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _serviceManager.TInsert(service);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Service service)
        {
            if (service == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _serviceManager.TUpdate(service);
            return Ok(service);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _serviceManager.TDelete(id);

            return Ok();
        }
    }
}