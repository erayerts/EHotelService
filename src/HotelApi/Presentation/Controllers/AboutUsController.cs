using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Concrete;
using HotelApi.Shared.DtoEntities;
using HotelApi.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Presentation.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AboutUsController : ControllerBase
    {
        private readonly AboutUsManager _aboutUsManager;
        public AboutUsController(AboutUsManager aboutUsManager)
        {
            _aboutUsManager = aboutUsManager;
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            AboutUs resultObj = _aboutUsManager.TGetById(id);

            return Ok(resultObj);
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {
            List<AboutUs> resultList = _aboutUsManager.TGetList();

            return Ok(resultList);
        }

        [HttpPost("insert")]
        public IActionResult Post([FromBody] AboutUs aboutUs)
        {
            if (aboutUs == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _aboutUsManager.TInsert(aboutUs);
            return Ok(aboutUs);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] AboutUs aboutUs)
        {
            if (aboutUs == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _aboutUsManager.TUpdate(aboutUs);
            return Ok(aboutUs);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _aboutUsManager.TDelete(id);

            return Ok();
        }
    }
}