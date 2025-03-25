using StudyingTesting.poker_hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyProject
{

    [TestClass]
    public class AssertDemo
    {

        [TestMethod]
        public void LearnAssert()
        {

            int Expected = 7;
            Card c = new Card(Expected, Suit.SPADES);

            Assert.AreEqual(Expected, c.Number);
        }

        [TestMethod]
        public void DecimalComparison()
        {

            int x = 7;

            int y = 15;

            //int delta = 10;
            int delta = 2;
            //Assert.AreEqual(x, y , delta);

            Assert.AreEqual(x, y, delta, "\nDelta too much!!");//with custom
        }

        [TestMethod]
        public void TestAreNotEquals()
        {
            int x = 7;
            int y = 15;
            int delta = 10;
            //int delta = 2;

            Assert.AreNotEqual(x, y, delta, "\nDelta not WANTED!!");//with custom

        }
        [TestMethod]
        public void TestAreSame()
        {
            Card c = new Card(2, Suit.SPADES);

            Card c2 = c;

            Card c3 = new Card(2, Suit.SPADES);

            Assert.AreSame(c2, c3 ,"\nObject not same reference!!");//with custom

        }
        [TestMethod]
        public void TestAreNotSame()
        {
            Card c = new Card(2, Suit.SPADES);

            Card c2 = c;

            Card c3 =  new Card(2, Suit.SPADES);

            Assert.AreNotSame(c2, c3, "\nObject  same reference!!");//with custom

        }
    }
}
