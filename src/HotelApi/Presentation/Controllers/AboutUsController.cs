using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Concrete;
using HotelApi.Shared.DtoEntities;
using HotelApi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Presentation.Controllers
{
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

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            List<AboutUs> resultList = _aboutUsManager.TGetList();

            return Ok(resultList);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AboutUs aboutUs)
        {
            if (aboutUs == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _aboutUsManager.TInsert(aboutUs);
            return Ok();
        }
    }
}