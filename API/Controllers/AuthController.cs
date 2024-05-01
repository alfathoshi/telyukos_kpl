using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using telyukos;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private const string filePath = "users.json";
        private List<User> _users;

        public AuthController()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                _users = JsonSerializer.Deserialize<List<User>>(json);
            }
            else
            {
                _users = new List<User>();
            }
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(_users);
            System.IO.File.WriteAllText(filePath, json);
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (_users.Any(u => u.Email == user.Email))
            {
                return Conflict("Email sudah terdaftar");
            }

            _users.Add(user);
            SaveUsers();
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

            return Ok("Login berhasil");
        }
    }
}
