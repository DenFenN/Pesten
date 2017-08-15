using Pesten.GameEngine.Cards;

namespace Pesten.GameEngine.SpecialCardCalculators
{
    internal interface ISpecialCardCalculator
    {
        bool IsSpecialCard(Face face);

        SpecialCardOption Option(Face face);
    }
}
