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
    [Route("api/[controller]")]
    public class TestimonialReviewController : ControllerBase
    {
        private readonly TestimonialReviewManager _testimonialReviewManager;

        public TestimonialReviewController(TestimonialReviewManager testimonialReviewManager)
        {
            _testimonialReviewManager = testimonialReviewManager;
        }

        [HttpPost]
        public IActionResult Post([FromBody] TestimonialReview testimonialReview)
        {
            if (testimonialReview == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _testimonialReviewManager.TInsert(testimonialReview);
            return Ok();
        }
    }
}