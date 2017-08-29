using Pesten.GameEngine.Cards;

namespace Pesten.GameEngine.SpecialCardCalculators
{
    internal interface ISpecialCardCalculator
    {
        int NumberOfNormalCards { get; }
        int NumberOfJokers { get; }
        int CardsToDeal { get; }

        bool IsSpecialCard(Face face);
        SpecialCardOption Option(Face face);

    }
}
