using Pesten.GameEngine.SpecialCardCalculators;
using System;
using System.Collections.Generic;

namespace Pesten.GameEngine.Cards
{
    class Deck
    {
        private ISpecialCardCalculator _specialCardCalculator;
        private readonly List<Card> _cards = new List<Card>();

        private Deck()
        {

        }

        internal static bool TryCreateNewDeck(ISpecialCardCalculator specialCardCalculator, out Deck deck)
        {
            deck = new Deck()
            {
                _specialCardCalculator = specialCardCalculator
            };

            // Add 'normal' cards (i.e. not Jokers):
            AddNormalCards(deck);


            // Add Jokers:
            AddJokers(deck, 3);

            return deck._cards.Count > 52;

        }

        private static void AddNormalCards(Deck deck)
        {
            
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                if (suit == Suit.None) continue;

                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    var card = new Card(suit, face, deck._specialCardCalculator);

                    deck._cards.Add(card);
                }
            }
        }

        private static void AddJokers(Deck deck, int number)
        {
            for (int i = 0; i < number; i++)
            {
                deck._cards.Add(new Joker(Suit.None, Face.Joker, deck._specialCardCalculator));
            }
        }

    }
}
