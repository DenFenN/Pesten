using Pesten.GameEngine.Cards;
using Pesten.GameEngine.Players;
using Pesten.GameEngine.SpecialCardCalculators;

namespace Pesten.GameEngine
{
    internal class Engine
    {
        internal ICardManager _cardManager;
        internal IPlayerManager _playerManager;

        public void Deal()
        {
            _cardManager.Deal(_playerManager);
        }

        public Engine(ISpecialCardCalculator specialCardCalculator, int numberOfPlayers = 1)
        {
            _playerManager = new PlayerManager(numberOfPlayers);
            _cardManager = new CardManager(_playerManager.NumberOfPlayers, specialCardCalculator);
        }
    }
}
