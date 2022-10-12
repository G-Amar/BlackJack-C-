namespace Blackjack_UI
{
    partial class PlayBlackjackForm
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
            this.BidValueLabel = new System.Windows.Forms.Label();
            this.CurrentBidLabel = new System.Windows.Forms.Label();
            this.DealerLabel = new System.Windows.Forms.Label();
            this.DealerHand = new System.Windows.Forms.Label();
            this.DealerValueLabel = new System.Windows.Forms.Label();
            this.DealerValue = new System.Windows.Forms.Label();
            this.PlayerValue = new System.Windows.Forms.Label();
            this.PlayerValueLabel = new System.Windows.Forms.Label();
            this.PlayerHand = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BidValueLabel
            // 
            this.BidValueLabel.AutoSize = true;
            this.BidValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BidValueLabel.Location = new System.Drawing.Point(166, 39);
            this.BidValueLabel.Name = "BidValueLabel";
            this.BidValueLabel.Size = new System.Drawing.Size(67, 26);
            this.BidValueLabel.TabIndex = 6;
            this.BidValueLabel.Text = "<bid>";
            // 
            // CurrentBidLabel
            // 
            this.CurrentBidLabel.AutoSize = true;
            this.CurrentBidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CurrentBidLabel.Location = new System.Drawing.Point(35, 39);
            this.CurrentBidLabel.Name = "CurrentBidLabel";
            this.CurrentBidLabel.Size = new System.Drawing.Size(134, 26);
            this.CurrentBidLabel.TabIndex = 5;
            this.CurrentBidLabel.Text = "Current Bid: ";
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DealerLabel.Location = new System.Drawing.Point(35, 100);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(82, 26);
            this.DealerLabel.TabIndex = 7;
            this.DealerLabel.Text = "Dealer:";
            // 
            // DealerHand
            // 
            this.DealerHand.AutoSize = true;
            this.DealerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DealerHand.Location = new System.Drawing.Point(123, 100);
            this.DealerHand.Name = "DealerHand";
            this.DealerHand.Size = new System.Drawing.Size(152, 26);
            this.DealerHand.TabIndex = 8;
            this.DealerHand.Text = "<dealer hand>";
            // 
            // DealerValueLabel
            // 
            this.DealerValueLabel.AutoSize = true;
            this.DealerValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DealerValueLabel.Location = new System.Drawing.Point(35, 147);
            this.DealerValueLabel.Name = "DealerValueLabel";
            this.DealerValueLabel.Size = new System.Drawing.Size(74, 26);
            this.DealerValueLabel.TabIndex = 9;
            this.DealerValueLabel.Text = "Value:";
            // 
            // DealerValue
            // 
            this.DealerValue.AutoSize = true;
            this.DealerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DealerValue.Location = new System.Drawing.Point(115, 147);
            this.DealerValue.Name = "DealerValue";
            this.DealerValue.Size = new System.Drawing.Size(156, 26);
            this.DealerValue.TabIndex = 10;
            this.DealerValue.Text = "<dealer value>";
            // 
            // PlayerValue
            // 
            this.PlayerValue.AutoSize = true;
            this.PlayerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PlayerValue.Location = new System.Drawing.Point(115, 267);
            this.PlayerValue.Name = "PlayerValue";
            this.PlayerValue.Size = new System.Drawing.Size(155, 26);
            this.PlayerValue.TabIndex = 14;
            this.PlayerValue.Text = "<player value>";
            // 
            // PlayerValueLabel
            // 
            this.PlayerValueLabel.AutoSize = true;
            this.PlayerValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PlayerValueLabel.Location = new System.Drawing.Point(35, 267);
            this.PlayerValueLabel.Name = "PlayerValueLabel";
            this.PlayerValueLabel.Size = new System.Drawing.Size(74, 26);
            this.PlayerValueLabel.TabIndex = 13;
            this.PlayerValueLabel.Text = "Value:";
            // 
            // PlayerHand
            // 
            this.PlayerHand.AutoSize = true;
            this.PlayerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PlayerHand.Location = new System.Drawing.Point(164, 220);
            this.PlayerHand.Name = "PlayerHand";
            this.PlayerHand.Size = new System.Drawing.Size(151, 26);
            this.PlayerHand.TabIndex = 12;
            this.PlayerHand.Text = "<player hand>";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PlayerLabel.Location = new System.Drawing.Point(35, 220);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(123, 26);
            this.PlayerLabel.TabIndex = 11;
            this.PlayerLabel.Text = "Your Hand:";
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.QuitButton.Location = new System.Drawing.Point(600, 343);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(238, 64);
            this.QuitButton.TabIndex = 15;
            this.QuitButton.Text = "Close";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Visible = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.HitButton.Location = new System.Drawing.Point(40, 343);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(143, 64);
            this.HitButton.TabIndex = 16;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.StandButton.Location = new System.Drawing.Point(220, 343);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(143, 64);
            this.StandButton.TabIndex = 17;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // PlayBlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 428);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PlayerValue);
            this.Controls.Add(this.PlayerValueLabel);
            this.Controls.Add(this.PlayerHand);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.DealerValue);
            this.Controls.Add(this.DealerValueLabel);
            this.Controls.Add(this.DealerHand);
            this.Controls.Add(this.DealerLabel);
            this.Controls.Add(this.BidValueLabel);
            this.Controls.Add(this.CurrentBidLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PlayBlackjackForm";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BidValueLabel;
        private System.Windows.Forms.Label CurrentBidLabel;
        private System.Windows.Forms.Label DealerLabel;
        private System.Windows.Forms.Label DealerHand;
        private System.Windows.Forms.Label DealerValueLabel;
        private System.Windows.Forms.Label DealerValue;
        private System.Windows.Forms.Label PlayerValue;
        private System.Windows.Forms.Label PlayerValueLabel;
        private System.Windows.Forms.Label PlayerHand;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
    }
}