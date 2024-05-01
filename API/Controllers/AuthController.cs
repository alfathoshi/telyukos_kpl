using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly List<User> _users = new List<User>();

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (_users.Any(u => u.Email == user.Email))
            {
                return Conflict("Email sudah terdaftar");
            }

            _users.Add(user);
            return Ok("Registrasi berhasil");
        }

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (existingUser == null)
            {
                return Unauthorized("Email atau password salah");
            }

            // Implement authentication logic here (e.g., generate JWT token)

            return Ok("Login berhasil");
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
