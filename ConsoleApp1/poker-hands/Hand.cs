using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTesting.poker_hands
{
    public class Hand 
    {

        
        //Hand h = new Hand("8C TS KC 9H 4S"); 
        public Hand(String handString)
        {

            for(int i = 0;i < cards.Length; i++)
            {
                cards[i] = new Card(1, Suit.CLUBS);
            }
            //...TODO
        }

        public Hand()
        {



        }

        private Card[] cards = new Card[5];

        public Card[] Cards { get => cards; set => cards = value; }

        public void Sort()
        {
            Array.Sort<Card>(cards);
        }

        public WinningRank FindWinningRank()
        {
            Sort();
            
            int[] counts = new int[15];
            
            // Count occurrences
            foreach (Card card in cards)
            {
                counts[card.Number]++;
            }

            // Look for four of a kind
            foreach (int count in counts)
            {
                if (count == 4)
                    return WinningRank.FOUR_A_KIND;
            }
            
            // Look for three of a kind
            foreach (int count in counts)
            {
                if (count == 3)
                    return WinningRank.THREE_A_KIND;
            }

            // Count pairs
            int pairCount = 0;
            foreach (int count in counts)
            {
                if (count == 2)
                    pairCount++;
            }

            if (pairCount == 2) return WinningRank.PAIRS;
            if (pairCount == 1) return WinningRank.PAIR;
            
            return WinningRank.HIGH;
        }

    }
}