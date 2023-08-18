using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Concrete;
using HotelApi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Presentation.Controllers{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IntroductionController : ControllerBase
    {
        private readonly IntroductionManager _introductionManager;

        public IntroductionController(IntroductionManager introductionManager)
        {
            _introductionManager = introductionManager;
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            Introduction resultObj = _introductionManager.TGetById(id);

            return Ok(resultObj);
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            List<Introduction> resultList = _introductionManager.TGetList();

            return Ok(resultList);
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