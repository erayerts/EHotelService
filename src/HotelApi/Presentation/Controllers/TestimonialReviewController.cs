using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using HotelApi.BusinessLogic.Concrete;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TestimonialReviewController : ControllerBase
    {
        private readonly TestimonialReviewManager _testimonialReviewManager;

        public TestimonialReviewController(TestimonialReviewManager testimonialReviewManager)
        {
            _testimonialReviewManager = testimonialReviewManager;
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            TestimonialReview resultObj = _testimonialReviewManager.TGetById(id);

            return Ok(resultObj);
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            List<TestimonialReview> resultList = _testimonialReviewManager.TGetList();

            return Ok(resultList);
        }

        [HttpPost("insert")]
        public IActionResult Post([FromBody] TestimonialReview testimonialReview)
        {
            if (testimonialReview == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _testimonialReviewManager.TInsert(testimonialReview);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] TestimonialReview testimonialReview)
        {
            if (testimonialReview == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _testimonialReviewManager.TUpdate(testimonialReview);
            return Ok(testimonialReview);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id) 
        {
            _testimonialReviewManager.TDelete(id);
            
            return Ok();
        }
    }
}