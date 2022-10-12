namespace Blackjack_UI
{
    partial class OpeningForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PlayeBalanceLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.PlayerBidLabel = new System.Windows.Forms.Label();
            this.BidBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WelcomeLabel.Location = new System.Drawing.Point(229, 55);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(350, 39);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Blackjack";
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PlayButton.Location = new System.Drawing.Point(612, 327);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(143, 64);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play!";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PlayeBalanceLabel
            // 
            this.PlayeBalanceLabel.AutoSize = true;
            this.PlayeBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PlayeBalanceLabel.Location = new System.Drawing.Point(38, 168);
            this.PlayeBalanceLabel.Name = "PlayeBalanceLabel";
            this.PlayeBalanceLabel.Size = new System.Drawing.Size(156, 26);
            this.PlayeBalanceLabel.TabIndex = 3;
            this.PlayeBalanceLabel.Text = "Your Balance: ";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BalanceLabel.Location = new System.Drawing.Point(200, 168);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(114, 26);
            this.BalanceLabel.TabIndex = 4;
            this.BalanceLabel.Text = "<balance>";
            // 
            // PlayerBidLabel
            // 
            this.PlayerBidLabel.AutoSize = true;
            this.PlayerBidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PlayerBidLabel.Location = new System.Drawing.Point(38, 236);
            this.PlayerBidLabel.Name = "PlayerBidLabel";
            this.PlayerBidLabel.Size = new System.Drawing.Size(105, 26);
            this.PlayerBidLabel.TabIndex = 5;
            this.PlayerBidLabel.Text = "Enter bid:";
            // 
            // BidBox
            // 
            this.BidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BidBox.Location = new System.Drawing.Point(149, 233);
            this.BidBox.Name = "BidBox";
            this.BidBox.Size = new System.Drawing.Size(141, 32);
            this.BidBox.TabIndex = 6;
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BidBox);
            this.Controls.Add(this.PlayerBidLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.PlayeBalanceLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "OpeningForm";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label PlayeBalanceLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label PlayerBidLabel;
        private System.Windows.Forms.TextBox BidBox;
    }
}

