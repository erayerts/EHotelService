using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Shared.Entities
{
    public class TestimonialReview
    {
        public string? Review { get; set; }
        public string? Author { get; set; }
        public byte Rate { get; set; }
    }
}