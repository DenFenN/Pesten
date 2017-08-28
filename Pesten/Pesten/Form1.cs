using Pesten.GameEngine.Cards;
using Pesten.GameEngine.Players;
using System;
using System.Windows.Forms;

namespace Pesten.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            listBoxCards.Items.Clear();

            foreach (var item in Program.GameEngine._cardManager.Cards)
            {
                listBoxCards.Items.Add(item.ToString());
            }

            textBoxCardCount.Text = Program.GameEngine._cardManager.Cards.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.GameEngine.Deal();

            FillPlayersCombo();

            FillCardsPanel();

        }

        private bool _initialFill = true;

        private void FillPlayersCombo()
        {
            comboBoxPlayers.Items.Clear();

            foreach (var player in Program.GameEngine._playerManager.Players)
            {
                var comboBoxItem = player.ToComboboxItem();

                comboBoxPlayers.Items.Add(comboBoxItem);

                if (comboBoxPlayers.Items.Count == 1)
                {
                    comboBoxPlayers.Text = comboBoxItem.ToString();
                }
            }

            _initialFill = false;
        }

        private void FillCardsPanel()
        {
            if (comboBoxPlayers.SelectedItem is PlayerComboboxItem comboboxItem)
            {
                panel1.Controls.Clear();

                var ucCards = new UserControlCards(comboboxItem.Player.Cards)
                {
                    Dock = DockStyle.Fill
                };

                panel1.Controls.Add(ucCards);
            }
        }

        private void comboBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initialFill) FillCardsPanel();
        }
    }


}
