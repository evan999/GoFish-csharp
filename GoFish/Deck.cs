using System;
using System.Collections.Generic;
using System.Text;

namespace GoFish
{
    public class Deck
    {
        Random random = new Random();
        public List<Card> Cards { get; set; }

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

        //Array suits = Enum.GetValues(typeof(Suit));
        //Array faces = Enum.GetValues(typeof(Face));

        public Deck()
        {
            //Cards = new List<Card>();
            List<Card> deck = new List<Card>();

            for (int face = 2; face <= 14; face++)
            {
                for (int suit = 0; suit <= 3; suit++)
                {
                    Card card = new Card(face, suit);
                    deck.Add(card);
                    Console.WriteLine(card.face + " " + card.suit);
                    //Console.WriteLine(Deck[face][suit]);
                }
                //int face = random.Next(2, 14);
                //int suit = random.Next(0, 3);

            }
            /*
            foreach(Suit suit in Enum.GetValues(typeof(Face)))
            {
                foreach(Face face in Enum.GetValues(typeof(Suit)))
                {
                    Card card = new Card(face, suit);
                    Cards.Add(card);
                }
            }
            */
        }

        public List<Card> Shuffle(List<Card> deck)
        {
            List<Card> shuffled = new List<Card>();
            for (int card = shuffled.Count - 1; card > 0; card--)
            {
                int rand = random.Next(card + 1);
                if (rand != card)
                {
                    Card cardR = shuffled[rand];
                    shuffled[rand] = shuffled[card];
                    shuffled[card] = cardR;
                }
            }
            return shuffled;
        }


    }
}

