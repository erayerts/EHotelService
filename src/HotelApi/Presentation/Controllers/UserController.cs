using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HotelApi.BusinessLogic.Concrete;
using HotelApi.Shared.DtoEntities;
using HotelApi.Shared.Entities;
using HotelApi.Shared.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace HotelApi.Presentation.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager _userManager;
        private readonly IConfiguration _config;

        public UserController(UserManager userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            bool isUserValid = _userManager.ValidateUser(username, _userManager.EncryptPassword(password));

            if (isUserValid)
            {
                var claims = new[]
            {
                new Claim("username", username),
                // Add other claims as needed
            };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    _config["Jwt:Issuer"],
                    _config["Jwt:Audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(30), // Set token expiration
                    signingCredentials: creds
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }

            return Unauthorized();
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {
            List<UserAccount_output> user_output = new();
            List<UserAccount> user = _userManager.TGetList();

            for (int i = 0; i < user.Count; i++)
            {
                UserAccount userEntity = user[i];
                UserAccount_output userEntityOutput = new UserAccount_output
                {
                    UserAccountId = userEntity.UserAccountId,
                    Username = userEntity.Username,
                    Role = userEntity.Role
                };

                user_output.Add(userEntityOutput);
            }


            return Ok(user_output);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserAccountDto userDto)
        {
            UserAccount user = new()
            {
                Username = userDto.Username,
                PasswordHash = _userManager.EncryptPassword(userDto.Password),
                EMail = userDto.EMail,
                Role = UserRoles.User.ToString()
            };

            if (userDto == null)
            {
                return BadRequest("Body cannot get null value.");
            }

            _userManager.TInsert(user);

            return Ok(user);
        }

        [HttpPut("update")]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int UserId)
        {
            _userManager.TDelete(UserId);
            return Ok();
        }
    }
}