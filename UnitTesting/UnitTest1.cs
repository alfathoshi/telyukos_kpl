using System.Diagnostics;
using telyukos;
using static telyukos.AuthState;

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
            var StartClose =stateAwal.getNextState(State.START, Trigger.CLOSE);
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
            Role.Roles roleName = Role.Roles.Penyewa;

            // Act
            string result = Role.getRole(roleName);

            // Assert
            Assert.AreEqual("PENYEWA", result);
        }

        [TestMethod]
        public void getRolePemilik()
        {
            // Arrange
            Role.Roles roleName = Role.Roles.Pemilik;

            // Act
            string result = Role.getRole(roleName);

            // Assert
            Assert.AreEqual("PEMILIK", result);
        }
    }
}