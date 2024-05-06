using telyukos;

namespace UnitTestAutomataReservasi
{
    [TestClass]
    public class TestAutomataReservasi
    {
        [TestMethod]
        public void GetNextState()
        {
            //Arrange
            ReservasiKos reservasi = new ReservasiKos();

            //Act
            var Start = reservasi.GetNextState(ReservasiKos.ReservasiState.START, ReservasiKos.ReservasiTrigger.MULAI);
            var LihatKos = reservasi.GetNextState(ReservasiKos.ReservasiState.LIHAT_INFORMASI_KOS, ReservasiKos.ReservasiTrigger.MELIHAT_KOS);
            var PilihKos = reservasi.GetNextState(ReservasiKos.ReservasiState.PILIH_KOS, ReservasiKos.ReservasiTrigger.PILIH_RESERVASI);
            var Reservasi = reservasi.GetNextState(ReservasiKos.ReservasiState.RESERVASI, ReservasiKos.ReservasiTrigger.MENGISI_DATA);
            var Konfirmasi = reservasi.GetNextState(ReservasiKos.ReservasiState.DAFTAR_RESERVASI, ReservasiKos.ReservasiTrigger.DAFTAR_DITERIMA);
            var Batal = reservasi.GetNextState(ReservasiKos.ReservasiState.PILIH_KOS, ReservasiKos.ReservasiTrigger.BACK);

            //Assert
            Assert.AreEqual(ReservasiKos.ReservasiState.LIHAT_INFORMASI_KOS, Start);
            Assert.AreEqual(ReservasiKos.ReservasiState.PILIH_KOS, LihatKos);
            Assert.AreEqual(ReservasiKos.ReservasiState.RESERVASI, PilihKos);
            Assert.AreEqual(ReservasiKos.ReservasiState.DAFTAR_RESERVASI, Reservasi);
            Assert.AreEqual(ReservasiKos.ReservasiState.RESERVASI_BERHASIL, Konfirmasi);
            Assert.AreEqual(ReservasiKos.ReservasiState.LIHAT_INFORMASI_KOS, Batal);

        }
    }

    [TestClass]
    public class TestTableDriven
    {
        [TestMethod]
        public void getRentStatusTersedia()
        {
            // Arrange
            RentStatus.RentsStatus rents = RentStatus.RentsStatus.Status1;

            // Act
            string getStatus = RentStatus.getRentStatus(rents);

            // Assert
            Assert.AreEqual("Tersedia", getStatus);
        }

        [TestMethod]
        public void getRentStatusDisewa()
        {
            // Arrange
            RentStatus.RentsStatus rents = RentStatus.RentsStatus.Status2;

            // Act
            string getStatus = RentStatus.getRentStatus(rents);

            // Assert
            Assert.AreEqual("Disewa", getStatus);
        }
    }
}
