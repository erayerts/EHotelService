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
    public class RoomController : ControllerBase
    {
        private readonly RoomManager _roomManager;

        public RoomController(RoomManager roomManager)
        {
            _roomManager = roomManager;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Room room)
        {
            if (room == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _roomManager.TInsert(room);
            return Ok();
        }
    }
}