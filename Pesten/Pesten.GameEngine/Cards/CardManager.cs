using Pesten.GameEngine.Players;
using Pesten.GameEngine.SpecialCardCalculators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Pesten.GameEngine.Cards
{
    internal class CardManager: ICardManager
    {
        public IReadOnlyList<ICard> Cards => _cards;

        private ICard _lastPlayedCard;

        private readonly List<ICard> _cards = new List<ICard>();
        private readonly List<ICard> _stock = new List<ICard>();

        private IPlayerManager _playerManager;

        private int _numberOfDecks = 0;
        private ISpecialCardCalculator _specialCardCalculator;

        private int GetNumberOfDecks(int numberOfPlayers)
        {
            var numberOfDecks = (int)Math.Round(numberOfPlayers / 4d, 2);
            var numberOfDecksRound = Math.Round(numberOfPlayers / 4d, 2) - numberOfDecks;

            if (numberOfDecksRound > 0) numberOfDecks += 1;

            return numberOfDecks;
        }

        private void PrepareCards()
        {
            AddDecks();
            Shuffle();
        }

        public CardManager(int numberOfPlayers, ISpecialCardCalculator specialCardCalculator)
        {
            _numberOfDecks = GetNumberOfDecks(numberOfPlayers);
            _specialCardCalculator = specialCardCalculator;
        }

        public ICard LastPlayedCard => _lastPlayedCard;

        public void Deal(IPlayerManager playerManager)
        {
            _playerManager = playerManager;

            PrepareCards();

            var cardsToDeal = _playerManager.Players.Count * _specialCardCalculator.CardsToDeal;

            playerManager.ResetCards();
            int cardIndex;

            for (cardIndex = 0; cardIndex < cardsToDeal; cardIndex += playerManager.Players.Count)
            {
                var playerCardIndex = cardIndex;
                foreach (var player in playerManager.Players)
                {
                    var card = _cards[playerCardIndex];
                    Debug.Assert(!card.Dealt);

                    player.DealCard(card);
                    card.Dealt = true;
                    playerCardIndex++;
                }
            }

            _lastPlayedCard = _cards[cardIndex + 1];
        }

        private void Shuffle()
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

        private bool AddDecks()
        {
            _cards.Clear();

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
