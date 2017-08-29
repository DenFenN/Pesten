using Pesten.GameEngine.Cards;
using System;
using System.Collections.Generic;

namespace Pesten.GameEngine.Players
{
    class Player
    {
        private readonly List<ICard> _cards = new List<ICard>();

        public Guid Id { get; private set; }
        public bool IsAiPlayer { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyCollection<ICard> Cards => _cards;


        internal static bool TryCreateNewPlayer(bool aiPlayer, string playerName, out Player player)
        {
            player = new Player(aiPlayer, playerName);
            return player.Id != Guid.Empty;
        }

        internal void ResetCards()
        {
            _cards.Clear();
        }

        public void DealCard(ICard card)
        {
            _cards.Add(card);
        }

        private Player()
        {
            Id = Guid.Empty;
        }

        public Player(bool aiPlayer, string playerName) : this()
        {
            IsAiPlayer = aiPlayer;
            Id = Guid.NewGuid();
            Name = playerName;
        }

        public PlayerComboboxItem ToComboboxItem()
        {
            return new PlayerComboboxItem(this);
        }
    }
}
