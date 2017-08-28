using Pesten.GameEngine.Cards;
using Pesten.GameEngine.Players;
using Pesten.GameEngine.SpecialCardCalculators;

namespace Pesten.GameEngine
{
    internal class Engine
    {
        internal CardManager _cardManager;
        internal PlayerManager _playerManager;

        public void Deal()
        {
            _cardManager.Deal(_playerManager);
        }

        public Engine(SpecialCardCalculator specialCardCalculator, int numberOfPlayers = 1)
        {
            _playerManager = new PlayerManager(numberOfPlayers);
            _cardManager = new CardManager(_playerManager.NumberOfPlayers, specialCardCalculator);
        }
    }
}
