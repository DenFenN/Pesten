using System.Collections.Generic;
using System.Windows.Forms;

namespace Pesten.GameEngine.Cards
{
    internal partial class UserControlCards : UserControl, ICardUserControl
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
                tabControl1.TabPages.Add(new CardTabPage(card));
            }
        }

        public ICard GetSelectedCard()
        {
            if (tabControl1.SelectedTab != null)
            {
                if (tabControl1.SelectedTab is CardTabPage CardTabPage)
                {
                    return CardTabPage.Card;
                }
            }

            return null;
        }



        private class CardTabPage : TabPage
        {
            private ICard _card;

            internal ICard Card => _card;

            public CardTabPage(ICard card)
            {
                _card = card;
                Update();
            }


            public new void Update()
            {
                Text = _card.ToString();

                base.Update();
            }
        }
    }


}
