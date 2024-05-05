﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;
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

        internal void SetUsers(List<User> users)
        {
            _users = users;
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
            // Precondition: Name harus valid
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Nama tidak boleh kosong", nameof(name));
            }

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
                return NotFound("Kos tidak ditemukan");
            }

            existingUser.Kos.Add(kos);
            SaveUsers(); // Simpan data ke file setelah diperbarui
            return Ok("Reservasi berhasil");
        }


    }
}