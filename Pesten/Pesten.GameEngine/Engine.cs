using Pesten.GameEngine.Cards;
using Pesten.GameEngine.Players;
using Pesten.GameEngine.SpecialCardCalculators;
using System;

namespace Pesten.GameEngine
{
    internal class Engine
    {
        internal CardManager _cardManager;
        internal PlayerManager _playerManager;

        public Engine(SpecialCardCalculator specialCardCalculator, int numberOfPlayers = 1)
        {
            if (numberOfPlayers < 2)
            {
                numberOfPlayers = 2;
            }

            var numberOfDecks = (int)Math.Round(numberOfPlayers / 4d, 2);
            var numberOfDecksRound = Math.Round(numberOfPlayers / 4d, 2) - numberOfDecks;

            if (numberOfDecksRound > 0) numberOfDecks += 1;

            _cardManager = new CardManager(numberOfDecks, specialCardCalculator);
            _playerManager = new PlayerManager(numberOfPlayers);

        }

        public void Shuffle()
        {
            _cardManager.Shuffle();
        }



    }
}
