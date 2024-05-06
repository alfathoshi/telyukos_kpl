using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using telyukos;

namespace API.Tests
{
    [TestClass]
    public class KosControllerTests
    {
        private readonly KosController _controller;

        public KosControllerTests()
        {
            _controller = new KosController();
        }

        [TestMethod]
        public void GetAllKos_WhenEmpty_ReturnsOkWithMessage()
        {
            // Arrange
            var controller = new KosController();
            var clearKosListMethod = typeof(KosController).GetMethod("ClearKosList", BindingFlags.NonPublic | BindingFlags.Instance);
            clearKosListMethod.Invoke(controller, null); // Bersihkan daftar kos untuk memastikan kosong

            // Act
            var result = controller.GetAllKos();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Belum ada data", ((OkObjectResult)result).Value);
        }

        [TestMethod]
        public void CreateKos_WithValidKos_ReturnsOkWithMessage()
        {
            // Arrange
            var clearKosListMethod = typeof(KosController).GetMethod("ClearKosList", BindingFlags.NonPublic | BindingFlags.Instance);
            clearKosListMethod.Invoke(_controller, null);
            var kos = new Kos { Id = 1, Nama = "Kos A", Harga = 1000000, Alamat = "Alamat A" };

            // Act
            var result = _controller.CreateKos(kos);

            // Assert
            Assert.IsNotNull(result);
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual("Kos berhasil ditambahkan", okResult.Value);
        }


        [TestMethod]
        public void CreateKos_WithExistingId_ReturnsOkWithMessage()
        {
            // Arrange
            var clearKosListMethod = typeof(KosController).GetMethod("ClearKosList", BindingFlags.NonPublic | BindingFlags.Instance);
            clearKosListMethod.Invoke(_controller, null);
            var kos1 = new Kos { Id = 1, Nama = "Kos A", Harga = 1000000, Alamat = "Alamat A" };
            _controller.CreateKos(kos1);

            var kos2 = new Kos { Id = 1, Nama = "Kos B", Harga = 1500000, Alamat = "Alamat B" };

            // Act
            var result = _controller.CreateKos(kos2);

            // Assert
            Assert.IsNotNull(result);
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual("Kos berhasil ditambahkan", okResult.Value);
        }

        [TestMethod]
        public void UpdateKos_WithValidId_ReturnsOkWithMessage()
        {
            // Arrange
            var clearKosListMethod = typeof(KosController).GetMethod("ClearKosList", BindingFlags.NonPublic | BindingFlags.Instance);
            clearKosListMethod.Invoke(_controller, null);
            var kos = new Kos { Id = 1, Nama = "Kos A", Harga = 1000000, Alamat = "Alamat A" };
            _controller.CreateKos(kos);

            var updatedKos = new Kos { Id = 1, Nama = "Kos A Updated", Harga = 1500000, Alamat = "Alamat A Updated" };

            // Act
            var result = _controller.UpdateKos(1, updatedKos);

            // Assert
            Assert.IsNotNull(result);
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual("Kos berhasil diperbarui", okResult.Value);
        }

        [TestMethod]
        public void DeleteKos_WithValidId_ReturnsOkWithMessage()
        {
            // Arrange
            var clearKosListMethod = typeof(KosController).GetMethod("ClearKosList", BindingFlags.NonPublic | BindingFlags.Instance);
            clearKosListMethod.Invoke(_controller, null);
            var kos = new Kos { Id = 1, Nama = "Kos A", Harga = 1000000, Alamat = "Alamat A" };
            _controller.CreateKos(kos);

            // Act
            var result = _controller.DeleteKos(1);

            // Assert
            Assert.IsNotNull(result);
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual("Kos berhasil dihapus", okResult.Value);
        }


        // Add more test methods for other controller methods

    }
}
