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
            Program.GameEngine.Shuffle();

            listBoxCards.Items.Clear();


            foreach (var item in Program.GameEngine._cardManager.Cards)
            {
                listBoxCards.Items.Add(item.ToString());
            }

            textBoxCardCount.Text = Program.GameEngine._cardManager.Cards.Count.ToString();

        }
    }
}
