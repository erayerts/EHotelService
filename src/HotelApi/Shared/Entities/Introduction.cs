using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Shared.Entities
{
    public class Introduction
    {
        public int IntroductionId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? DiscoverNowLink { get; set; }
    }
}