namespace Pesten.GameEngine.Players
{
    class PlayerComboboxItem
    {
        public Player Player { get; private set; }


        public PlayerComboboxItem(Player player)
        {
            Player = player;
        }

        public override string ToString()
        {
            return Player.Name;
        }
    }


}
