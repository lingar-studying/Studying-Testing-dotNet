using Newtonsoft.Json.Linq;
using StudyingTesting.poker_hands;
using StudyingTesting.users;

namespace TestMyProject
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void TestAdminCanOpen()
        {
            User user = new User();
            user.Roles.Add(User_Role.ADMIN);
            // {}, 1, 2, 3, 1 2,1 3,2 3, 123

            user.AddTable();
            Assert.IsNotNull(user.Tables[0], "\nAdmin didn't add table!");
            //Assert.AreEqual(Expected, c.Number);
        }

        [TestMethod]
        public void TestManagerCanOpen()
        {
            User user = new User();
            user.Roles.Add(User_Role.MANAGER);
            // {}, 1, 2, 3, 1 2,1 3,2 3, 123

            user.AddTable();
            Assert.IsNotNull(user.Tables[0], "\nManager didn't add table!");
            //Assert.AreEqual(Expected, c.Number);
        }

        [TestMethod]
        public void TestPlayerCannotOpen()
        {
            User user = new User();
            user.Roles.Add(User_Role.PLAYER);
            // {}, 1, 2, 3, 1 2,1 3,2 3, 123

            user.AddTable();
            Assert.AreEqual(0, user.Tables.Count  ,"\nPlayer should not open table");
            //Assert.AreEqual(Expected, c.Number);
        }

        [TestMethod]
        public void TestManagerAndAdminCanOpen()
        {
            User user = new User();
            user.Roles.Add(User_Role.ADMIN);

            user.Roles.Add(User_Role.MANAGER);
            // {}, 1, 2, 3, 1 2,1 3,2 3, 123

            user.AddTable();
            Assert.IsNotNull(user.Tables[0], "\nManager and Admin didn't add table!");
            //Assert.AreEqual(Expected, c.Number);
        }



    }

}