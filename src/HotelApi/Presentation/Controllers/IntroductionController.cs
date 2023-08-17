using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Concrete;
using HotelApi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Presentation.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class IntroductionController : ControllerBase
    {
        private readonly IntroductionManager _introductionManager;

        public IntroductionController(IntroductionManager introductionManager)
        {
            _introductionManager = introductionManager;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Introduction introduction)
        {
            if (introduction == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _introductionManager.TInsert(introduction);
            return Ok();
        }
    }
}