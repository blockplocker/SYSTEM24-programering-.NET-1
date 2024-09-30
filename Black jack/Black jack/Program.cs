using System.Drawing;

namespace Black_jack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();


            foreach (var card in deck.GetCards())
            {
                Console.WriteLine($"{card.Color} {card.Number} (Value: {card.Value})");
            }

            deck.Shuffle();

            // Draw a single card
            Card drawnCard = deck.DrawCard();
            Console.WriteLine($"Drawn Card: {drawnCard.Color} {drawnCard.Number}");

            //Card dragetKort = Deck.GetCard();
            //Console.WriteLine("Du drog " + dragetKort.Number + " av " + dragetKort.Color);
            //Console.WriteLine("Poängen för detta kort är: " + dragetKort.Value);
        }
    }
}
