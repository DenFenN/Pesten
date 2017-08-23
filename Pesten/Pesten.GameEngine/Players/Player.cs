using Pesten.GameEngine.Cards;
using System;
using System.Collections.Generic;

namespace Pesten.GameEngine.Players
{
    class Player
    {
        private readonly List<Card> _cards = new List<Card>();
        public Guid Id { get; private set; }
        public bool IsAiPlayer { get; private set; }

        internal static bool TryCreateNewPlayer(bool aiPlayer, out Player player)
        {
            player = new Player(aiPlayer);

            return player.Id != Guid.Empty;
        }

        private Player()
        {
            Id = Guid.Empty;
        }

        public Player(bool aiPlayer) : this()
        {
            IsAiPlayer = aiPlayer;
            Id = Guid.NewGuid();
        }
    }
}
