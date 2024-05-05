using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;
using telyukos.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private const string filePath = "users.json";
        private List<User> _users;
        private List<Kos> _kos = new List<Kos>();

        public AuthController()
        {
            try
            {
                LoadUsers(); // Load data dari file saat aplikasi dimulai
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error load data: {ex.Message}");
            }
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

        [HttpGet]
        public IActionResult GetUser()
        {
            if (_users.Count == 0)
            {
                return Ok("Belum ada data");
            }

            return Ok(_users);
        }

        [HttpGet("{name}")]
        public IActionResult GetUserbyName(string name)
        {
            if (_users.Count == 0)
            {
                return Ok("Belum ada data");
            }

            foreach (User user in _users)
            {
                if (user.Email == name)
                {
                    return Ok(user);
                }
            }
            return Ok("Data tidak ada");
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (_users.Any(u => u.Email == user.Email))
            {
                return Conflict("Email sudah terdaftar");
            }

            if (user.Role.ToLower() != "penyewa" && user.Role.ToLower() != "pemilik")
            {
                return BadRequest("Role harus diisi dengan 'penyewa' atau 'pemilik'");
            }

            user.Kos = _kos;
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

            return Ok(new { message = "Login berhasil", role = existingUser.Role });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKos(string id)
        {
            var existingKos = _users.FirstOrDefault(k => k.Email == id);
            if (existingKos == null)
            {
                return NotFound("Kos tidak ditemukan");
            }

            _users.Remove(existingKos);
            SaveUsers(); // Simpan data ke file setelah dihapus
            return Ok("Kos berhasil dihapus");
        }

        [HttpPut("{akun}")]
        public IActionResult Reservasi(string akun, Kos kos)
        {
            var existingUser = _users.FirstOrDefault(k => k.Email == akun);
            if (existingUser == null)
            {
                return NotFound("User tidak ditemukan");
            }
            kos.Penyewa = null;
            existingUser.Kos.Add(kos);
            SaveUsers(); // Simpan data ke file setelah diperbarui
            return Ok("Reservasi berhasil");
        }
    }
}