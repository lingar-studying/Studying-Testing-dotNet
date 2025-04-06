﻿namespace StudyingTesting.poker_hands
{
    public class Card : IComparable<Card>
    {
        private int number;
        private Suit suit;

        public Card(int number, Suit suit)
        {
            this.number = number;
            this.suit = suit;
        }

        public int Number { get => number; set => number = value; }

        public Suit Suit { get => suit; set => suit = value; }

        public override string ToString()
        {
            return suit + "-" + number;
        }

        public int CompareTo(Card other)
        {
            return number.CompareTo(other.number);
        }


    }
}
