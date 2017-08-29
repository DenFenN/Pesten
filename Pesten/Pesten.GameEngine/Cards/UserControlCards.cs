using System.Collections.Generic;
using System.Windows.Forms;

namespace Pesten.GameEngine.Cards
{
    public partial class UserControlCards : UserControl
    {
        private readonly List<ICard> _cards = new List<ICard>();

        public UserControlCards()
        {
            InitializeComponent();
        }

        internal UserControlCards(IEnumerable<ICard> cards) : this()
        {
            tabControl1.TabPages.Clear();

            foreach (var card in cards)
            {
                tabControl1.TabPages.Add(card.ToString());
            }
        }
    }
}
