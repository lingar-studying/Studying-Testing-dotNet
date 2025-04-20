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

            for (int i = 0; i < cards.Length; i++)
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

            List<int> numbers = new List<int>();
            for (int i = 0; i < cards.Length; i++)
            {
                numbers.Add(cards[i].Number);
            }

            
            int maxSame = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (count > maxSame)
                {
                    maxSame = count;
                }
            }

            if (maxSame == 4)
                return WinningRank.FOUR_A_KIND;

            if (maxSame == 3)
                return WinningRank.THREE_A_KIND;

            return WinningRank.HIGH;
        }

    }
}