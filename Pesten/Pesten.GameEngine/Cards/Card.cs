using Pesten.GameEngine.SpecialCardCalculators;

namespace Pesten.GameEngine.Cards
{
    internal class Card
    {
        public Suit Suit { get; set; }

        public Face Face { get; set; }

        public bool SpecialCard { get; set; }

        public bool IsJoker { get; set; }

        public Card(Suit suit, Face face, ISpecialCardCalculator specialCardCalculator)
        {
            Suit = suit;
            Face = face;

            SpecialCard = specialCardCalculator.IsSpecialCard(Face);
        }



    }
}
