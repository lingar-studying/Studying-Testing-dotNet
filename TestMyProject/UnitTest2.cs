using StudyingTesting.poker_hands.game_area;
using StudyingTesting.users;
using System.Reflection;

namespace TestMyProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestAddTable()
        {
            // Arrange
            var user = new User();

            // Act
            user.AddTable();

            // Assert
            // Using reflection to access the private field 'tables'
            var tablesField = typeof(User).GetField("tables", BindingFlags.NonPublic | BindingFlags.Instance);
            var tables = (List<Table>)tablesField.GetValue(user);
            Assert.AreEqual(1, tables.Count);
        }
    }
}