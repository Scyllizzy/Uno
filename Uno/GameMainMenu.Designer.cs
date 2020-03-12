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
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl.Location = new System.Drawing.Point(32, 16);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(116, 18);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "Select Players";
            // 
            // ListBoxAvailablePlayers
            // 
            this.ListBoxAvailablePlayers.FormattingEnabled = true;
            this.ListBoxAvailablePlayers.Location = new System.Drawing.Point(26, 39);
            this.ListBoxAvailablePlayers.Name = "ListBoxAvailablePlayers";
            this.ListBoxAvailablePlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxAvailablePlayers.Size = new System.Drawing.Size(129, 316);
            this.ListBoxAvailablePlayers.TabIndex = 1;
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Location = new System.Drawing.Point(176, 309);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(136, 46);
            this.BtnStartGame.TabIndex = 2;
            this.BtnStartGame.Text = "Start Game!";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.Location = new System.Drawing.Point(339, 104);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(119, 39);
            this.BtnAddPlayer.TabIndex = 3;
            this.BtnAddPlayer.Text = "Add player";
            this.BtnAddPlayer.UseVisualStyleBackColor = true;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // BtnEditPlayer
            // 
            this.BtnEditPlayer.Location = new System.Drawing.Point(339, 208);
            this.BtnEditPlayer.Name = "BtnEditPlayer";
            this.BtnEditPlayer.Size = new System.Drawing.Size(119, 39);
            this.BtnEditPlayer.TabIndex = 4;
            this.BtnEditPlayer.Text = "Edit player";
            this.BtnEditPlayer.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePlayer
            // 
            this.BtnDeletePlayer.Location = new System.Drawing.Point(339, 312);
            this.BtnDeletePlayer.Name = "BtnDeletePlayer";
            this.BtnDeletePlayer.Size = new System.Drawing.Size(119, 39);
            this.BtnDeletePlayer.TabIndex = 5;
            this.BtnDeletePlayer.Text = "Delete player";
            this.BtnDeletePlayer.UseVisualStyleBackColor = true;
            this.BtnDeletePlayer.Click += new System.EventHandler(this.BtnDeletePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMsg.Location = new System.Drawing.Point(187, 145);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(45, 32);
            this.lblErrMsg.TabIndex = 7;
            this.lblErrMsg.Text = "label2\r\n\r\n";
            // 
            // GameMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 383);
            this.Controls.Add(this.lblErrMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeletePlayer);
            this.Controls.Add(this.BtnEditPlayer);
            this.Controls.Add(this.BtnAddPlayer);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.ListBoxAvailablePlayers);
            this.Controls.Add(this.Lbl);
            this.Name = "GameMainMenu";
            this.Text = "GameMainMenu";
            this.Load += new System.EventHandler(this.GameMainMenu_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrMsg;
    }
}