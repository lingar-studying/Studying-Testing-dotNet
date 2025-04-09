﻿using System;
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

            // Check for pairs
            for (int i = 1; i < cards.Length; i++)
            {
                if (cards[i].Number == cards[i - 1].Number)
                {
                    return WinningRank.PAIR;  // Return PAIR if a pair is found
                }
            }

            // If no pair is found, return HIGH
            return WinningRank.HIGH;
        }


    }
}
