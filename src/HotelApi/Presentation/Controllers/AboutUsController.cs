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
    public class AboutUsController : ControllerBase
    {
        private readonly AboutUsManager _aboutUsManager;
        public AboutUsController(AboutUsManager aboutUsManager)
        {
            _aboutUsManager = aboutUsManager;
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