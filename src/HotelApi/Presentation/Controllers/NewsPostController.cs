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
    public class NewsPostController : ControllerBase
    {
        private readonly NewsPostManager _newsPostManager;

        public NewsPostController(NewsPostManager newsPostManager)
        {
            _newsPostManager = newsPostManager;
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewsPost newsPost)
        {
            if (newsPost == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _newsPostManager.TInsert(newsPost);
            return Ok();
        }
    }
}