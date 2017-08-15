using System;
using Pesten.GameEngine.Cards;

namespace Pesten.GameEngine.SpecialCardCalculators
{
    class DutchSpecialCardCalculator : ISpecialCardCalculator
    {
        public SpecialCardOption Option(Face face)
        {
            switch (face)
            {
                case Face.Two:
                    return SpecialCardOption.Take2Cards;

                case Face.Seven:
                    return SpecialCardOption.PlayAnotherCard;

                case Face.Eight:
                    return SpecialCardOption.NextPlayerSkipTurn;

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

        public bool IsSpecialCard(Face face)
        {
            switch (face)
            {
                case Face.Two:
                case Face.Seven:
                case Face.Eight:
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
