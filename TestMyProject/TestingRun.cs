using StudyingTesting.poker_hands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMyProject;

[TestClass]
public class TestingRun
{
    [TestMethod]
    public void TestThreeOfAKind()
    {
        Hand hand = new Hand();
        hand.Cards = new Card[] {
            new Card(7, Suit.HEARTS),
            new Card(7, Suit.DIAMONDS),
            new Card(7, Suit.SPADES),
            new Card(4, Suit.CLUBS),
            new Card(9, Suit.HEARTS)
        };
    
        Assert.AreEqual(WinningRank.THREE_A_KIND, hand.FindWinningRank(), 
            "Should identify three of a kind");
    }

    [TestMethod]
    public void TestTwoPair()
    {
        Hand hand = new Hand();
        hand.Cards = new Card[] {
            new Card(7, Suit.HEARTS),
            new Card(7, Suit.DIAMONDS),
            new Card(8, Suit.SPADES),
            new Card(8, Suit.CLUBS),
            new Card(9, Suit.HEARTS)
        };
    
        Assert.AreEqual(WinningRank.PAIRS, hand.FindWinningRank(), 
            "Should identify two pairs");
    }
    
    [TestMethod]
    public void TestFourOfAKind()
    {
        Hand hand = new Hand();
        hand.Cards = new Card[] {
            new Card(7, Suit.HEARTS),
            new Card(7, Suit.DIAMONDS),
            new Card(7, Suit.SPADES),
            new Card(7, Suit.CLUBS),
            new Card(9, Suit.HEARTS)
        };

        Assert.AreEqual(WinningRank.FOUR_A_KIND, hand.FindWinningRank(), 
            "Should identify four of a kind");
    }
}