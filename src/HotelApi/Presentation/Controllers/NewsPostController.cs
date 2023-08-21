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
    public class NewsPostController : ControllerBase
    {
        private readonly NewsPostManager _newsPostManager;

        public NewsPostController(NewsPostManager newsPostManager)
        {
            _newsPostManager = newsPostManager;
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            NewsPost resultObj = _newsPostManager.TGetById(id);

            return Ok(resultObj);
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            List<NewsPost> resultList = _newsPostManager.TGetList();

            return Ok(resultList);
        }

        [HttpPost("insert")]
        public IActionResult Post([FromBody] NewsPost newsPost)
        {
            if (newsPost == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _newsPostManager.TInsert(newsPost);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] NewsPost newsPost)
        {
            if (newsPost == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _newsPostManager.TUpdate(newsPost);
            return Ok(newsPost);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _newsPostManager.TDelete(id);

            return Ok();
        }
    }
}