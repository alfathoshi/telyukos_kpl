using telyukos_library.Searching;

namespace TestProject
{
    [TestClass]
    public class SequentialSearchTest
    {
        [TestMethod]
        public void TestSearchKos()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int searchValue = 3;
            Func<int, bool> predicate = x => x == searchValue;
            int expected = 3;

            // Act
            int result = SearchKos.Search(array, predicate);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSearchKos_WithObject()
        {
            // Arrange
            string[] array = { "apple", "banana", "orange", "grape", "kiwi" };
            string searchValue = "orange";
            Func<string, bool> predicate = x => x == searchValue;
            string expected = "orange";

            // Act
            string result = SearchKos.Search(array, predicate);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}