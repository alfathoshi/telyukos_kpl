using telyukos.State;
using static telyukos.State.AuthState;
using static telyukos.State.SewaState;


namespace UnitTesting
{
    [TestClass]
    public class Automata
    {
        [TestMethod]
        public void getNextState()
        {
            //Arrange
            AuthState stateAwal = new AuthState();

            //act
            var start = stateAwal.getNextState(State.START, Trigger.LOGIN_DITERIMA);
            var LoginClose = stateAwal.getNextState(State.LOGIN, Trigger.CLOSE);
            var StartClose = stateAwal.getNextState(State.START, Trigger.CLOSE);
            var logout = stateAwal.getNextState(State.LOGIN, Trigger.LOGOUT);

            //Assert
            Assert.AreEqual(State.LOGIN, start);
            Assert.AreEqual(State.EXIT, LoginClose);
            Assert.AreEqual(State.EXIT, StartClose);
            Assert.AreEqual(State.START, logout);


        }
    }

    [TestClass]
    public class tableDriven
    {
        [TestMethod]
        public void getRolePenyewa()
        {
            // Arrange
            Role.RoleUser roleName = Role.RoleUser.RENTER;

            // Act
            string result = Role.getRole(roleName);

            // Assert
            Assert.AreEqual("penyewa", result);
        }

        [TestMethod]
        public void getRolePemilik()
        {
            // Arrange
            Role.RoleUser roleName = Role.RoleUser.OWNER;

            // Act
            string result = Role.getRole(roleName);

            // Assert
            Assert.AreEqual("pemilik", result);
        }
        [TestClass]
        public class TestAutomataReservasi
        {
            [TestMethod]
            public void GetNextState()
            {
                //Arrange
                SewaState reservasi = new SewaState();

                //Act
                var PilihKos = reservasi.GetNextState(ReservasiState.LIHAT_KOS, ReservasiTrigger.PILIH_KOS);
                var Berhasil = reservasi.GetNextState(ReservasiState.RESERVASI, ReservasiTrigger.KONFIRMASI);
                var Cancel = reservasi.GetNextState(ReservasiState.RESERVASI, ReservasiTrigger.CANCEL);


                //Assert
                Assert.AreEqual(ReservasiState.RESERVASI, PilihKos);
                Assert.AreEqual(ReservasiState.RESERVASI_BERHASIL, Berhasil);
                Assert.AreEqual(ReservasiState.RESERVASI_CANCEL, Cancel);


            }
        }
        [TestClass]
        public class TestTableDriven
        {
            [TestMethod]
            public void getRentStatusTersedia()
            {
                // Arrange
                KosStatus.RentsStatus rents = KosStatus.RentsStatus.AVAIL;

                // Act
                string getStatus = KosStatus.getRentStatus(rents);

                // Assert
                Assert.AreEqual("Tersedia", getStatus);
            }

            [TestMethod]
            public void getRentStatusDisewa()
            {
                // Arrange
                KosStatus.RentsStatus rents = KosStatus.RentsStatus.FULL;

                // Act
                string getStatus = KosStatus.getRentStatus(rents);

                // Assert
                Assert.AreEqual("Disewa", getStatus);
            }
        }
    }
}