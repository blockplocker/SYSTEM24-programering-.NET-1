using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
    class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] colors = { "Hearts ♥", "Diamonds ♦", "Clubs ♣", "Spades ♠" };
            string[] numbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (string color in colors)
            {
                foreach (string number in numbers)
                {
                    cards.Add(new Card(color, number));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
        public Card DrawCard()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("The deck is empty.");

            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }

        public List<Card> GetCards()
        {
            return cards;
        }
    }
}
