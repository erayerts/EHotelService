using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Shared.Entities
{
    public class NewsPost
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public string? CoverImage { get; set; }
        public string? PostLink { get; set; }
        public int PostDate { get; set; }
    }
}