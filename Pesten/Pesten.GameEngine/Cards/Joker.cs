using Pesten.GameEngine.SpecialCardCalculators;

namespace Pesten.GameEngine.Cards
{
    class Joker : Card
    {
        public Joker(Suit suit, Face face, SpecialCardCalculator specialCardCalculator) : base(suit, face, specialCardCalculator)
        {
            IsJoker = true;
        }
    }
}
