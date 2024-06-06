using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
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

        internal void SetUsers(List<User> users)
        {
            _users = users;
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(_users);
            System.IO.File.WriteAllText(filePath, json);
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
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

        [HttpGet("{email}")]
        public IActionResult GetUserbyName(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Email tidak b  oleh kosong", nameof(email));
            }

            var user = _users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                return NotFound("Data tidak ada");
            }
            return Ok(user);
        }



        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // Precondition: User tidak boleh null
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            // Precondition: Email harus valid
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("Email tidak boleh kosong", nameof(user.Email));
            }

            // Precondition: Password harus valid
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password tidak boleh kosong", nameof(user.Password));
            }

            // Precondition: Role harus diisi dengan 'penyewa' atau 'pemilik'
            if (user.Role.ToLower() != "penyewa" && user.Role.ToLower() != "pemilik")
            {
                throw new ArgumentException("Role harus diisi dengan 'penyewa' atau 'pemilik'", nameof(user.Role));
            }

            // Precondition: Email harus unik
            if (_users.Any(u => u.Email == user.Email))
            {
                return Conflict("Email sudah terdaftar");
            }

            // Hash password sebelum disimpan
            user.Password = ComputeSha256Hash(user.Password);

            // Operasi registrasi berhasil
            _users.Add(user);
            SaveUsers();

            // Postcondition: User terdaftar dalam daftar user
            if (!_users.Contains(user))
            {
                throw new Exception("Registrasi gagal");
            }

            return Ok("Registrasi berhasil");
        }

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            // Precondition: User tidak boleh null
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            // Precondition: Email harus valid
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("Email tidak boleh kosong", nameof(user.Email));
            }

            // Precondition: Password harus valid
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password tidak boleh kosong", nameof(user.Password));
            }

            // Bandingkan hash password
            var existingUser = _users.FirstOrDefault(u => u.Email == user.Email && u.Password == ComputeSha256Hash(user.Password));
            if (existingUser == null)
            {
                return Unauthorized("Email atau password salah");
            }

            return Ok(new { message = "Login berhasil", role = existingUser.Role });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKos(string id)
        {
            // Precondition: ID harus valid
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("ID tidak boleh kosong", nameof(id));
            }

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
            // Precondition: Akun tidak boleh kosong
            if (string.IsNullOrWhiteSpace(akun))
            {
                throw new ArgumentException("Akun tidak boleh kosong", nameof(akun));
            }

            // Precondition: Kos tidak boleh null
            if (kos == null)
            {
                throw new ArgumentNullException(nameof(kos));
            }
            var existingUser = _users.FirstOrDefault(k => k.Email == akun);
            if (existingUser == null)
            {
                return NotFound("User tidak ditemukan");
            }
            // Precondition: Kos tidak boleh duplikat
            if (kos.Penyewa.Contains(existingUser.Email))
            {
                return Conflict("Kos sudah terdaftar");
            }
            if (existingUser.Kos == null)
            {
                existingUser.Kos = new List<Kos>();
            }
            kos.Penyewa = null;
            existingUser.Kos.Add(kos);
            SaveUsers(); // Simpan data ke file setelah diperbarui
            return Ok("Reservasi berhasil");
        }

        [HttpPut("change-password")]
        public IActionResult ChangePassword([FromBody] User user)
        {
            // Precondition: Email tidak boleh kosong
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("Email tidak boleh kosong", nameof(user.Email));
            }

            // Precondition: Password baru tidak boleh kosong
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password baru tidak boleh kosong", nameof(user.Password));
            }

            var existingUser = _users.FirstOrDefault(u => u.Email == user.Email);
            if (existingUser == null)
            {
                return NotFound("Email tidak valid");
            }

            // Hash password baru sebelum disimpan
            existingUser.Password = ComputeSha256Hash(user.Password);
            SaveUsers();

            return Ok("Password berhasil diubah");
        }

        [HttpPut("update-profile")]
        public IActionResult UpdateProfile([FromBody] User updateUser)
        {

            // Precondition: Email tidak boleh kosong
            if (string.IsNullOrWhiteSpace(updateUser.Email))
            {
                throw new ArgumentException("Email tidak boleh kosong", nameof(updateUser.Email));
            }

            // Precondition: Password baru tidak boleh kosong
            if (string.IsNullOrWhiteSpace(updateUser.Password))
            {
                throw new ArgumentException("Password baru tidak boleh kosong", nameof(updateUser.Password));
            }

            // Bandingkan hash password
            var existingUser = _users.FirstOrDefault(u => u.Role == updateUser.Role);
            if (existingUser == null) 
            {
                return Unauthorized("Email atau password salah");

            }
            //hash password sebelum disimpan 
            existingUser.Password = ComputeSha256Hash(updateUser.Password);
            //update profile
            existingUser.Email = updateUser.Email;
            SaveUsers();

            return Ok("Profile updated successfully.");

        }

    

    }
}