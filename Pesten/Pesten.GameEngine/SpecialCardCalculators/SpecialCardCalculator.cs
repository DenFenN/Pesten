using Pesten.GameEngine.Cards;

namespace Pesten.GameEngine.SpecialCardCalculators
{
    internal abstract class SpecialCardCalculator
    {
        public int NumberOfNormalCards = 52;
        public int NumberOfJokers = 3;

        public abstract bool IsSpecialCard(Face face);

        public abstract SpecialCardOption Option(Face face);
    }
}
