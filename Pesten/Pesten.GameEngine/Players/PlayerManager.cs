using System;
using System.Collections.Generic;

namespace Pesten.GameEngine.Players
{
    internal class PlayerManager
    {
        public int NumberOfPlayers { get; private set; }

        private readonly List<Player> _players = new List<Player>();
        public IReadOnlyList<Player> Players => _players;

        public PlayerManager(int numberOfPlayers)
        {
            if (numberOfPlayers < 2)
            {
                numberOfPlayers = 2;
            }

            NumberOfPlayers = numberOfPlayers;

            // First player is user.
            AddPlayer();

            // Rest is AI
            for (int i = 1; i < NumberOfPlayers; i++)
            {
                AddPlayer(true);
            }
        }

        private Guid AddPlayer(bool aiPlayer = false)
        {
            var playerName = $"Player {_players.Count + 1}";

            if (Player.TryCreateNewPlayer(aiPlayer, playerName, out Player player))
            {
                _players.Add(player);
                return player.Id;
            }

            return Guid.Empty;
        }

        public void ResetCards()
        {
            foreach (var player in _players)
            {
                player.ResetCards();
            }
        }
    }
}
