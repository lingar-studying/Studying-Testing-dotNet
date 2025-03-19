using Newtonsoft.Json.Linq;
using StudyingTesting.poker_hands;

namespace TestMyProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int Expected = 7;
            Card c = new Card(Expected, Suit.SPADES);

            Assert.AreEqual(Expected, c.Number);
        }


        [TestMethod]
        public void TestMethod2()
        {

            Card card = new Card(5, Suit.DIAMONDS);

            Console.WriteLine("card=" + card);

            Card card2 = new Card(7, Suit.HEARTS);

            Card card3 = new Card(2, Suit.HEARTS);


            Card card4 = new Card(14, Suit.HEARTS);

            Card card5 = new Card(10, Suit.SPADES);

            Card[] cards = { card, card2, card3, card4, card5 };

            Hand hand = new Hand();
            hand.Cards = cards;
            hand.Sort();
            int num = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                Assert.IsTrue(num <= cards[i].Number, $"Expected {cards[i].Number} to be greater than {num}, but it was not. lingar");
            
                num = cards[i].Number;
            }
            
        }
    }

}