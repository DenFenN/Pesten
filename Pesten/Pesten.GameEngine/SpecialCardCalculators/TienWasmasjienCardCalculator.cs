using Pesten.GameEngine.Cards;

namespace Pesten.GameEngine.SpecialCardCalculators
{
    class TienWasmasjienCardCalculator : SpecialCardCalculator
    {




        public override SpecialCardOption Option(Face face)
        {
            switch (face)
            {
                case Face.Two:
                    return SpecialCardOption.Take2Cards;

                case Face.Seven:
                    return SpecialCardOption.PlayAnotherCard;

                case Face.Eight:
                    return SpecialCardOption.NextPlayerSkipTurn;

                case Face.Ten:
                    return SpecialCardOption.GiveCardToNextPlayer;


                case Face.Jack:
                    return SpecialCardOption.ChooseNewSuit;

                case Face.Ace:
                    return SpecialCardOption.TurnDirection;

                case Face.Joker:
                    return SpecialCardOption.Take5Cards;


                default:
                    return SpecialCardOption.None;
            }
        }

        public override bool IsSpecialCard(Face face)
        {
            switch (face)
            {
                case Face.Two:
                case Face.Seven:
                case Face.Eight:
                case Face.Ten:
                case Face.Jack:
                case Face.Ace:
                case Face.Joker:
                    return true;

                default:
                    return false;
            }
        }
    }
}
