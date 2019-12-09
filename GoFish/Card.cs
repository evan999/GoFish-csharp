using System;
using System.Collections.Generic;
using System.Text;

namespace GoFish
{

    public class Card
    {
        public enum Suit
        {
            Clubs = 0,
            Diamonds = 1,
            Hearts = 2,
            Spades = 3
        };
        public enum Face
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Ace = 11,
            Jack = 12,
            Queen = 13,
            King = 14
        };


        public int face;
        public int suit;

        //public bool activeCard;

        Random random = new Random();

        //Array faceValues = Enum.GetValues(typeof(Face));
        //Array suitValues = Enum.GetValues(typeof(Suit));

        public Card()
        {

        }

        public Card(int face, int suit)
        {
            this.face = face;
            this.suit = suit;
        }


        public Card DrawCard()
        {
            // int card1Value = GetCardValue(card1);
            Card card = new Card();
            card.face = random.Next(2, 14);
            card.suit = random.Next(0, 3);
            // int card2Value = random.Next(1, 13);
            return card;
        }
    }
}
