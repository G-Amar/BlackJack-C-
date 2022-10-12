using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Blackjack_UI
{
    public partial class PlayBlackjackForm : Form
    {
        private int bid;
        private Deck deck;
        private Hand userHand;
        private Hand dealerHand;
        private int dealerValue;
        private int userValue;
        /// <summary>
        /// To update the previous form upon win/loss
        /// </summary>
        private OpeningForm prevForm;

        public PlayBlackjackForm(OpeningForm openingForm,int bid)
        {
            InitializeComponent();

            prevForm = openingForm;

            this.bid = bid;

            deck = new Deck();
            userHand = new Hand();
            dealerHand = new Hand();

            userHand.Add(deck);
            dealerHand.Add(deck);
            userHand.Add(deck);

            dealerValue = dealerHand.Value();
            userValue = userHand.Value();

            LoadFormData();

        }
        private void LoadFormData()
        {
            BidValueLabel.Text = "$" + bid.ToString();
            DealerHand.Text = dealerHand.Print();
            DealerValue.Text = dealerValue.ToString();
            PlayerHand.Text = userHand.Print();
            PlayerValue.Text = userValue.ToString();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            userHand.Add(deck);
            userValue = userHand.Value();
            LoadFormData();
            if (userValue > 21)
            {
                MessageBox.Show("Bust");
                Endgame();
            }
        }
        private void Endgame()
        {
            HitButton.Visible = false;
            StandButton.Visible = false;
            QuitButton.Visible = true;
            prevForm.LoadFormData();
        }

        private void StandButton_Click(object sender, EventArgs e)
        {

            while (dealerValue < 17 && (dealerValue < userValue)) //dealer has to stand if 17 or more
            {
                dealerHand.Add(deck);
                dealerValue = dealerHand.Value();
            }

            LoadFormData();

            if (dealerValue == userValue)
            {
                MessageBox.Show("Tie!");
                Balance.balance += bid;
                Endgame();
            }
            else if (dealerValue > 21 || dealerValue < userValue)
            {
                MessageBox.Show("You Win!");
                Balance.balance += 2*bid;
                Endgame();
            }
            else
            {
                MessageBox.Show("You Lose!");
                Endgame();
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
