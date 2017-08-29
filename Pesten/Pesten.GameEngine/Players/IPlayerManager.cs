using System.Collections.Generic;

namespace Pesten.GameEngine.Players
{
    internal interface IPlayerManager
    {
        IReadOnlyList<Player> Players { get; }

        int NumberOfPlayers { get; set; }

        void ResetCards();
    }
}
