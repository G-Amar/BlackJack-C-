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
    public partial class OpeningForm : Form
    {
        private int bid;
        public OpeningForm()
        {
            InitializeComponent();

            LoadFormData();
        }

        public void LoadFormData()
        {
            BalanceLabel.Text = "$" + Balance.balance.ToString();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(BidBox.Text, out bid))
            {
                if(bid >= 0 && bid <= Balance.balance)
                {
                    Balance.balance -= bid;
                    LoadFormData();
                    PlayBlackjackForm form =  new PlayBlackjackForm(this, bid);
                    form.Show();
                }
                else
                    MessageBox.Show("Invalid amount entered.");
            }
            else 
            {
                MessageBox.Show("Enter an integer value.");
            }
        }
    }
}
