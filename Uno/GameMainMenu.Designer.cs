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
            this.lblSelectPlayers = new System.Windows.Forms.Label();
            this.ListBoxAvailablePlayers = new System.Windows.Forms.ListBox();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.BtnAddPlayer = new System.Windows.Forms.Button();
            this.BtnEditPlayer = new System.Windows.Forms.Button();
            this.BtnDeletePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPlayerDetails = new System.Windows.Forms.Button();
            this.lblManagePlayers = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectPlayers
            // 
            this.lblSelectPlayers.AutoSize = true;
            this.lblSelectPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPlayers.Location = new System.Drawing.Point(32, 16);
            this.lblSelectPlayers.Name = "lblSelectPlayers";
            this.lblSelectPlayers.Size = new System.Drawing.Size(116, 18);
            this.lblSelectPlayers.TabIndex = 6;
            this.lblSelectPlayers.Text = "Select Players";
            // 
            // ListBoxAvailablePlayers
            // 
            this.ListBoxAvailablePlayers.FormattingEnabled = true;
            this.ListBoxAvailablePlayers.Location = new System.Drawing.Point(26, 45);
            this.ListBoxAvailablePlayers.Name = "ListBoxAvailablePlayers";
            this.ListBoxAvailablePlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxAvailablePlayers.Size = new System.Drawing.Size(129, 303);
            this.ListBoxAvailablePlayers.TabIndex = 0;
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Location = new System.Drawing.Point(193, 56);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(136, 46);
            this.BtnStartGame.TabIndex = 1;
            this.BtnStartGame.Text = "Start Game!";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.Location = new System.Drawing.Point(9, 39);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(119, 39);
            this.BtnAddPlayer.TabIndex = 0;
            this.BtnAddPlayer.Text = "Add player";
            this.BtnAddPlayer.UseVisualStyleBackColor = true;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // BtnEditPlayer
            // 
            this.BtnEditPlayer.Location = new System.Drawing.Point(9, 161);
            this.BtnEditPlayer.Name = "BtnEditPlayer";
            this.BtnEditPlayer.Size = new System.Drawing.Size(119, 39);
            this.BtnEditPlayer.TabIndex = 2;
            this.BtnEditPlayer.Text = "Edit player";
            this.BtnEditPlayer.UseVisualStyleBackColor = true;
            this.BtnEditPlayer.Click += new System.EventHandler(this.BtnEditPlayer_Click);
            // 
            // BtnDeletePlayer
            // 
            this.BtnDeletePlayer.Location = new System.Drawing.Point(9, 222);
            this.BtnDeletePlayer.Name = "BtnDeletePlayer";
            this.BtnDeletePlayer.Size = new System.Drawing.Size(119, 39);
            this.BtnDeletePlayer.TabIndex = 3;
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
            this.lblErrMsg.Location = new System.Drawing.Point(15, 282);
            this.lblErrMsg.MaximumSize = new System.Drawing.Size(120, 0);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(0, 16);
            this.lblErrMsg.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPlayerDetails);
            this.groupBox1.Controls.Add(this.lblManagePlayers);
            this.groupBox1.Controls.Add(this.lblErrMsg);
            this.groupBox1.Controls.Add(this.BtnAddPlayer);
            this.groupBox1.Controls.Add(this.BtnEditPlayer);
            this.groupBox1.Controls.Add(this.BtnDeletePlayer);
            this.groupBox1.Location = new System.Drawing.Point(361, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 355);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // BtnPlayerDetails
            // 
            this.BtnPlayerDetails.Location = new System.Drawing.Point(9, 100);
            this.BtnPlayerDetails.Name = "BtnPlayerDetails";
            this.BtnPlayerDetails.Size = new System.Drawing.Size(119, 39);
            this.BtnPlayerDetails.TabIndex = 1;
            this.BtnPlayerDetails.Text = "Player Details";
            this.BtnPlayerDetails.UseVisualStyleBackColor = true;
            this.BtnPlayerDetails.Click += new System.EventHandler(this.BtnPlayerDetails_Click);
            // 
            // lblManagePlayers
            // 
            this.lblManagePlayers.AutoSize = true;
            this.lblManagePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePlayers.Location = new System.Drawing.Point(6, 10);
            this.lblManagePlayers.Name = "lblManagePlayers";
            this.lblManagePlayers.Size = new System.Drawing.Size(128, 18);
            this.lblManagePlayers.TabIndex = 0;
            this.lblManagePlayers.Text = "Manage Players";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 355);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.Location = new System.Drawing.Point(217, 14);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(87, 31);
            this.lblUno.TabIndex = 5;
            this.lblUno.Text = "UNO!";
            // 
            // GameMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 383);
            this.Controls.Add(this.lblUno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.ListBoxAvailablePlayers);
            this.Controls.Add(this.lblSelectPlayers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "GameMainMenu";
            this.Text = "GameMainMenu";
            this.Load += new System.EventHandler(this.GameMainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectPlayers;
        private System.Windows.Forms.ListBox ListBoxAvailablePlayers;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Button BtnAddPlayer;
        private System.Windows.Forms.Button BtnEditPlayer;
        private System.Windows.Forms.Button BtnDeletePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblManagePlayers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Button BtnPlayerDetails;
    }
}