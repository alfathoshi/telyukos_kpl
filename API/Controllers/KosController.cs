using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using telyukos;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KosController : ControllerBase
    {
        private List<Kos> _kosList;
        private List<User> users = new List<User>();

        public KosController()
        {
            try
            {
                LoadKosListFromFile(); // Load data dari file saat aplikasi dimulai
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error load data: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult GetAllKos()
        {
            return Ok(_kosList);
        }

        [HttpGet("{name}")]
        public IActionResult GetUserbyName(string name)
        {
            if (_kosList.Count == 0)
            {
                return Ok("Belum ada data");
            }

            foreach (Kos kos in _kosList)
            {
                if (kos.Nama == name)
                {
                    return Ok(kos);
                }
            }
            return Ok("Data tidak ada");
        }

        [HttpPost]
        public IActionResult CreateKos(Kos kos)
        {
            // Cek apakah ada ID yang kosong (0)
            kos.Penyewa = new List<string>();
            var emptyId = _kosList.FirstOrDefault(k => k.Id == 0);
            if (emptyId != null)
            {
                // Gunakan ID yang kosong
                kos.Id = emptyId.Id;
                emptyId.Nama = kos.Nama;
                emptyId.Harga = kos.Harga;
                emptyId.Alamat = kos.Alamat;
                emptyId.Status = kos.Status;
                emptyId.Kapasitas = kos.Kapasitas;
                emptyId.Penyewa = kos.Penyewa;
            }
            else
            {
                // Cari ID yang belum digunakan
                int newId = 1;
                while (_kosList.Any(k => k.Id == newId))
                {
                    newId++;
                }
                kos.Id = newId;
                _kosList.Add(kos);
            }

            SaveKosListToFile(); // Simpan data ke file setelah ditambahkan
            return Ok("Kos berhasil ditambahkan");
        }



        [HttpPut("{id}")]
        public IActionResult UpdateKos(int id, Kos kos)
        {
            var existingKos = _kosList.FirstOrDefault(k => k.Id == id);
            if (existingKos == null)
            {
                return NotFound("Kos tidak ditemukan");
            }

            existingKos.Nama = kos.Nama;
            existingKos.Harga = kos.Harga;
            existingKos.Alamat = kos.Alamat;
            existingKos.Status = kos.Status;
            existingKos.Kapasitas = kos.Kapasitas;
            existingKos.Penyewa = kos.Penyewa;
            SaveKosListToFile(); // Simpan data ke file setelah diperbarui
            return Ok("Kos berhasil diperbarui");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKos(int id)
        {
            var existingKos = _kosList.FirstOrDefault(k => k.Id == id);
            if (existingKos == null)
            {
                return NotFound("Kos tidak ditemukan");
            }

            _kosList.Remove(existingKos);
            SaveKosListToFile(); // Simpan data ke file setelah dihapus
            return Ok("Kos berhasil dihapus");
        }

        private void SaveKosListToFile()
        {
            string json = JsonConvert.SerializeObject(_kosList);
            System.IO.File.WriteAllText("kos_data.json", json);
        }

        private void LoadKosListFromFile()
        {
            if (System.IO.File.Exists("kos_data.json"))
            {
                string json = System.IO.File.ReadAllText("kos_data.json");
                _kosList = JsonConvert.DeserializeObject<List<Kos>>(json);
            }
        }

       

    }
}
