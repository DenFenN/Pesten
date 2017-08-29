using Pesten.GameEngine.Players;
using System.Collections.Generic;

namespace Pesten.GameEngine.Cards
{
    internal interface ICardManager
    {
        void Deal(IPlayerManager playerManager);

        IReadOnlyList<ICard> Cards { get; }

    }
}
