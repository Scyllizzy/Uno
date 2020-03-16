namespace Uno
{
    partial class PlayerDetailsForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.BtnBackMainMenu = new System.Windows.Forms.Button();
            this.lblTotalGamesPlayed = new System.Windows.Forms.Label();
            this.lblLossCount = new System.Windows.Forms.Label();
            this.lblWinsCount = new System.Windows.Forms.Label();
            this.lblWinLoss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(22, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(72, 24);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "Details";
            // 
            // BtnBackMainMenu
            // 
            this.BtnBackMainMenu.Location = new System.Drawing.Point(59, 192);
            this.BtnBackMainMenu.Name = "BtnBackMainMenu";
            this.BtnBackMainMenu.Size = new System.Drawing.Size(173, 30);
            this.BtnBackMainMenu.TabIndex = 18;
            this.BtnBackMainMenu.Text = "Main Menu";
            this.BtnBackMainMenu.UseVisualStyleBackColor = true;
            this.BtnBackMainMenu.Click += new System.EventHandler(this.BtnBackMainMenu_Click);
            // 
            // lblTotalGamesPlayed
            // 
            this.lblTotalGamesPlayed.AutoSize = true;
            this.lblTotalGamesPlayed.Location = new System.Drawing.Point(43, 155);
            this.lblTotalGamesPlayed.Name = "lblTotalGamesPlayed";
            this.lblTotalGamesPlayed.Size = new System.Drawing.Size(105, 13);
            this.lblTotalGamesPlayed.TabIndex = 23;
            this.lblTotalGamesPlayed.Text = "Total Games Played:";
            // 
            // lblLossCount
            // 
            this.lblLossCount.AutoSize = true;
            this.lblLossCount.Location = new System.Drawing.Point(105, 126);
            this.lblLossCount.Name = "lblLossCount";
            this.lblLossCount.Size = new System.Drawing.Size(43, 13);
            this.lblLossCount.TabIndex = 22;
            this.lblLossCount.Text = "Losses:";
            // 
            // lblWinsCount
            // 
            this.lblWinsCount.AutoSize = true;
            this.lblWinsCount.Location = new System.Drawing.Point(114, 97);
            this.lblWinsCount.Name = "lblWinsCount";
            this.lblWinsCount.Size = new System.Drawing.Size(34, 13);
            this.lblWinsCount.TabIndex = 21;
            this.lblWinsCount.Text = "Wins:";
            // 
            // lblWinLoss
            // 
            this.lblWinLoss.AutoSize = true;
            this.lblWinLoss.Location = new System.Drawing.Point(92, 68);
            this.lblWinLoss.Name = "lblWinLoss";
            this.lblWinLoss.Size = new System.Drawing.Size(56, 13);
            this.lblWinLoss.TabIndex = 20;
            this.lblWinLoss.Text = "Win/Loss:";
            // 
            // PlayerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 244);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.BtnBackMainMenu);
            this.Controls.Add(this.lblTotalGamesPlayed);
            this.Controls.Add(this.lblLossCount);
            this.Controls.Add(this.lblWinsCount);
            this.Controls.Add(this.lblWinLoss);
            this.Name = "PlayerDetailsForm";
            this.Text = "PlayerDetailsForm";
            this.Load += new System.EventHandler(this.PlayerDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button BtnBackMainMenu;
        private System.Windows.Forms.Label lblTotalGamesPlayed;
        private System.Windows.Forms.Label lblLossCount;
        private System.Windows.Forms.Label lblWinsCount;
        private System.Windows.Forms.Label lblWinLoss;
    }
}