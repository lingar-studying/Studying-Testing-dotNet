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

        [TestMethod]
        public void TestHighCard()
        {
            Card card1 = new Card(2, Suit.CLUBS);
            Card card2 = new Card(5, Suit.HEARTS);
            Card card3 = new Card(7, Suit.SPADES);
            Card card4 = new Card(9, Suit.DIAMONDS);
            Card card5 = new Card(11, Suit.CLUBS);

            Hand hand = new Hand();
            hand.Cards = new Card[] { card1, card2, card3, card4, card5 };

            WinningRank rank = hand.FindWinningRank();

            Assert.AreEqual(WinningRank.HIGH, rank, "The hand should be High Card when no pair is present.");
        }

        [TestMethod]
        public void TestPair()
        {
            Card card1 = new Card(2, Suit.CLUBS);
            Card card2 = new Card(2, Suit.HEARTS);
            Card card3 = new Card(7, Suit.SPADES);
            Card card4 = new Card(9, Suit.DIAMONDS);
            Card card5 = new Card(11, Suit.CLUBS);

            Hand hand = new Hand();
            hand.Cards = new Card[] { card1, card2, card3, card4, card5 };

            WinningRank rank = hand.FindWinningRank();

            Assert.AreEqual(WinningRank.PAIR, rank, "The hand should be identified as a Pair.");
        }

        [TestMethod]
        public void TestPairDoesNotBecomeHighCard()
        {
            Card card1 = new Card(3, Suit.CLUBS);
            Card card2 = new Card(3, Suit.HEARTS);  // This makes it a Pair
            Card card3 = new Card(7, Suit.SPADES);
            Card card4 = new Card(9, Suit.DIAMONDS);
            Card card5 = new Card(11, Suit.CLUBS);

            Hand hand = new Hand();
            hand.Cards = new Card[] { card1, card2, card3, card4, card5 };

            WinningRank rank = hand.FindWinningRank();

            Assert.AreEqual(WinningRank.PAIR, rank, "A hand with a pair should not be considered a High Card.");
        }



    }

}