using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Shared.Entities
{
    public class AboutUs
    {
        public int AboutUsId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ReadNowLink { get; set; }
        public string? CoverImage { get; set; }
    }
}