using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class GenerateIDTest
    {
        [TestMethod]
        public void TestGenerateID()
        {
            // Arrange
            int expectedCounter = 1;

            // Act
            string id1 = RandomIntegerGenerator.GenerateID();
            string id2 = RandomIntegerGenerator.GenerateID();
            string id3 = RandomIntegerGenerator.GenerateID();

            // Assert
            Assert.AreEqual("001", id1);
            Assert.AreEqual("002", id2);
            Assert.AreEqual("003", id3);
            Assert.AreEqual(expectedCounter + 3, RandomIntegerGenerator.Counter);
        }
    }

    public class RandomIntegerGenerator
    {
        private static int counter = 1;

        public static string GenerateID()
        {
            string id = counter.ToString().PadLeft(3, '0');
            counter++;
            return id;
        }

        public static int Counter { get { return counter; } }
    }
}
