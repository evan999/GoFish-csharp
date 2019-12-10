using System;
using System.Collections.Generic;
using System.Text;

namespace GoFish
{
    public class Hand
    {
        List<Card> hand = new List<Card>();
        Random random = new Random();

        public List<Card> DealHandToPlayer(List<Card> hand)
        {
            for(int card = 0; card < 5; card++)
            {
                hand.Add(new Card(random.Next(1, 14), random.Next());
            }
            return hand;
        }

        public void DrawCardFromHand(List<Card> hand)
        {
            Console.WriteLine("Draw a card from your hand.");
            Console.WriteLine("Enter card face value");
            string cardDrawnFace = Console.ReadLine();
            Console.WriteLine("Enter card suit");
            string cardDrawnSuit = Console.ReadLine();

            int cardFace = Convert.ToInt32(cardDrawnFace);
            int cardSuit = Convert.ToInt32(cardDrawnSuit);

            
            
        }

    }
}
