using System;
using System.Collections.Generic;

namespace Pesten.GameEngine.Players
{
    internal class PlayerManager
    {
        private readonly List<Player> _players = new List<Player>();
        public IReadOnlyList<Player> Players => _players;

        public PlayerManager(int numberOfPlayers)
        {
            // First player is user.
            AddPlayer();

            // Rest is AI
            for (int i = 1; i < numberOfPlayers; i++)
            {
                AddPlayer(true);
            }
        }

        private Guid AddPlayer(bool aiPlayer = false)
        {
            if (Player.TryCreateNewPlayer(aiPlayer, out Player player))
            {
                _players.Add(player);
                return player.Id;
            }

            return Guid.Empty;
        }
    }
}
