using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

namespace telyukos
{
    [Route("api/[controller]")]
    [ApiController]
    public class KosController : ControllerBase
    {
        private List<Kos> _kosList = new List<Kos>();

        [HttpGet]
        public ActionResult<IEnumerable<Kos>> GetAllKos()
        {
            return _kosList;
        }

        [HttpPost]
        public IActionResult CreateKos(Kos kos)
        {
            _kosList.Add(kos);
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
            return Ok("Kos berhasil dihapus");
        }
    }
}