using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Concrete;
using HotelApi.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Presentation.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly RoomManager _roomManager;

        public RoomController(RoomManager roomManager)
        {
            _roomManager = roomManager;
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            Room resultObj = _roomManager.TGetById(id);

            return Ok(resultObj);
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {
            List<Room> resultList = _roomManager.TGetList();

            return Ok(resultList);
        }

        [HttpPost("insert")]
        public IActionResult Post([FromBody] Room room)
        {
            if (room == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _roomManager.TInsert(room);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Room room)
        {
            if (room == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _roomManager.TUpdate(room);
            return Ok(room);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _roomManager.TDelete(id);

            return Ok();
        }
    }
}