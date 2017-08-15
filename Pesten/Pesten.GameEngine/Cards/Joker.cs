using Pesten.GameEngine.SpecialCardCalculators;

namespace Pesten.GameEngine.Cards
{
    class Joker : Card
    {
        public Joker(Suit suit, Face face, ISpecialCardCalculator specialCardCalculator) : base(suit, face, specialCardCalculator)
        {
            IsJoker = true;
        }
    }
}
