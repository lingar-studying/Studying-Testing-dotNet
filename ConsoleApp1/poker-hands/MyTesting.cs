﻿namespace StudyingTesting.poker_hands
{
    public class MyTesting
    {
        public static void RunMe()
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

            foreach (Card c in hand.Cards)
            {
                Console.WriteLine(c);
            }
            hand.Sort();
            Console.WriteLine("After sorting:");
            foreach (Card c in hand.Cards)
            {
                Console.WriteLine(c);
            }

        }

    }
}
