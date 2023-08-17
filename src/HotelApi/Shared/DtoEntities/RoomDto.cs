using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Shared.DtoEntities
{
    public class RoomDto
    {
        public int RoomId { get; set; }
        public int Price { get; set; }
        public string? RoomName { get; set; }
        public string? PriceCurrency { get; set; }
        public string? Size { get; set; }
        public string? Capacity { get; set; }
        public string? Bed { get; set; }
        public string? Services { get; set; }
        public string? CoverImage { get; set; }
        public string? MoreDetailsLink { get; set; }
    }
}