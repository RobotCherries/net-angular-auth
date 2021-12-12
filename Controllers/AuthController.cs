using Microsoft.AspNetCore.Mvc;
using NetAngularAuth.Data;
using NetAngularAuth.DTOs;
using NetAngularAuth.Models;

namespace NetAngularAuth.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterDto dto)
        {
            if (dto == null) return BadRequest("Please fill in all of the register fields");

            System.Console.Write(dto);

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            var result = _userRepository.Create(user);

            return Created("Success", result);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            var user = _userRepository.GetByEmail(dto.Email);

            if (user == null) return BadRequest(new { message = "Invalid credentials" });

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return BadRequest(new { message = "Invalid credentials" });
            }

            return Ok(user);
        }
    }
}
