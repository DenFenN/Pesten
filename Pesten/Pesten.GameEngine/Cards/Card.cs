using Pesten.GameEngine.SpecialCardCalculators;
using System;

namespace Pesten.GameEngine.Cards
{
    internal class Card
    {
        public Guid Id { get; private set; }

        public bool Dealt { get; set; }

        public Suit Suit { get; set; }

        public Face Face { get; set; }

        public bool SpecialCard { get; set; }

        public bool IsJoker { get; set; }

        public Card(Suit suit, Face face, SpecialCardCalculator specialCardCalculator)
        {
            Suit = suit;
            Face = face;
            Id = Guid.NewGuid();

            SpecialCard = specialCardCalculator.IsSpecialCard(Face);
        }

        public override string ToString()
        {
            var result = string.Empty;

            if (IsJoker)
            {
                result = "Joker";
            }
            else
            {
                int character = 0;

                switch (Suit)
                {
                    case Suit.Hearts:
                        character = 9825;
                        break;

                    case Suit.Diamonds:
                        character = 9826;
                        break;

                    case Suit.Clubs:
                        character = 9831;
                        break;

                    case Suit.Spades:
                        character = 9828;
                        break;

                    default:
                        throw new Exception();
                }

                result = string.Format($"{Convert.ToChar(character)} {Face.ToString()} ");
            }

            return result;
        }

    }
}
