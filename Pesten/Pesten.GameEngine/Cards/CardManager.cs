using Pesten.GameEngine.SpecialCardCalculators;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Pesten.GameEngine.Cards
{
    internal class CardManager
    {
        private readonly List<Card> _cards = new List<Card>();
        private int _numberOfDecks = 0;

        private SpecialCardCalculator _specialCardCalculator;

        public IReadOnlyList<Card> Cards => _cards;

        public CardManager(int numberOfDecks, SpecialCardCalculator specialCardCalculator)
        {
            _numberOfDecks = numberOfDecks;
            _specialCardCalculator = specialCardCalculator;

            AddDecks();
        }

        internal void Shuffle()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

            int n = _cards.Count;

            while (n > 1)
            {
                var box = new byte[1];

                do
                {
                    provider.GetBytes(box);
                }
                while (!(box[0] < n * (Byte.MaxValue / n)));

                int k = (box[0] % n);

                n--;

                var value = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = value;
            }
        }

        internal bool AddDecks()
        {
            for (int i = 0; i < _numberOfDecks; i++)
            {
                // Add 'normal' cards (i.e. not Jokers):
                AddNormalCards();

                // Add Jokers:
                AddJokers(_specialCardCalculator.NumberOfJokers);
            }

            return _cards.Count == (_specialCardCalculator.NumberOfNormalCards + _specialCardCalculator.NumberOfJokers) * _numberOfDecks;
        }

        private void AddNormalCards()
        {

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                if (suit == Suit.None) continue;

                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    if (face == Face.Joker) continue;

                    var card = new Card(suit, face, _specialCardCalculator);

                    _cards.Add(card);
                }
            }
        }

        private void AddJokers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                _cards.Add(new Joker(Suit.None, Face.Joker, _specialCardCalculator));
            }
        }
    }
}
