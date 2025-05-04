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



        /// <summary>
        /// Validate between straigh flush to straight not flush
        /// https://projecteuler.net/problem=54
        /// Straight Flush: All cards are consecutive values of same suit.
        /// Straight: All cards are consecutive values.

        /// 
        /// </summary>
        /// <returns></returns>
        public WinningRank FindWinningRank()
        {

            Sort();

            int count1 = 0;
            bool isStraigh = true;
            bool sameSuit = true;
            for (int i = 1; i < cards.Length; i++)
            {

                if (cards[i].Number- Cards[i - 1].Number !=1 )
                {
                    isStraigh = false;
                    break;
                    
                }
                if(sameSuit)
                    sameSuit= cards[i].Suit.Equals(Cards[i-1].Suit);            



            }            

            if(isStraigh )
            {
                return WinningRank.STRAIGHT;
            }

            if (sameSuit && isStraigh )
            {

                return WinningRank.STRAIGHT_FLUSH;
            }



            return WinningRank.HIGH;
        }

    }
}
