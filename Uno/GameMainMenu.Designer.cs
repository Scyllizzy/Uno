namespace Uno
{
    partial class GameMainMenu
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
            this.Lbl = new System.Windows.Forms.Label();
            this.ListBoxAvailablePlayers = new System.Windows.Forms.ListBox();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.BtnAddPlayer = new System.Windows.Forms.Button();
            this.BtnEditPlayer = new System.Windows.Forms.Button();
            this.BtnDeletePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(49, 19);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(74, 13);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "Select Players";
            // 
            // ListBoxAvailablePlayers
            // 
            this.ListBoxAvailablePlayers.FormattingEnabled = true;
            this.ListBoxAvailablePlayers.Location = new System.Drawing.Point(26, 39);
            this.ListBoxAvailablePlayers.Name = "ListBoxAvailablePlayers";
            this.ListBoxAvailablePlayers.Size = new System.Drawing.Size(120, 134);
            this.ListBoxAvailablePlayers.TabIndex = 1;
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Location = new System.Drawing.Point(79, 191);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(136, 46);
            this.BtnStartGame.TabIndex = 2;
            this.BtnStartGame.Text = "Start Game!";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.Location = new System.Drawing.Point(176, 52);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(119, 23);
            this.BtnAddPlayer.TabIndex = 3;
            this.BtnAddPlayer.Text = "Add player";
            this.BtnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // BtnEditPlayer
            // 
            this.BtnEditPlayer.Location = new System.Drawing.Point(176, 92);
            this.BtnEditPlayer.Name = "BtnEditPlayer";
            this.BtnEditPlayer.Size = new System.Drawing.Size(119, 23);
            this.BtnEditPlayer.TabIndex = 4;
            this.BtnEditPlayer.Text = "Edit player";
            this.BtnEditPlayer.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePlayer
            // 
            this.BtnDeletePlayer.Location = new System.Drawing.Point(176, 132);
            this.BtnDeletePlayer.Name = "BtnDeletePlayer";
            this.BtnDeletePlayer.Size = new System.Drawing.Size(119, 23);
            this.BtnDeletePlayer.TabIndex = 5;
            this.BtnDeletePlayer.Text = "Delete player";
            this.BtnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // GameMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 260);
            this.Controls.Add(this.BtnDeletePlayer);
            this.Controls.Add(this.BtnEditPlayer);
            this.Controls.Add(this.BtnAddPlayer);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.ListBoxAvailablePlayers);
            this.Controls.Add(this.Lbl);
            this.Name = "GameMainMenu";
            this.Text = "GameMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.ListBox ListBoxAvailablePlayers;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Button BtnAddPlayer;
        private System.Windows.Forms.Button BtnEditPlayer;
        private System.Windows.Forms.Button BtnDeletePlayer;
    }
}