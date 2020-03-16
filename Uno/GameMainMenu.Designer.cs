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
            this.BtnPlayerDetails = new System.Windows.Forms.Button();
            this.lblManagePlayers = new System.Windows.Forms.Label();
            this.lblUno = new System.Windows.Forms.Label();
            this.pnlSelectPlayers = new System.Windows.Forms.Panel();
            this.pnlSelectPlayersLbl = new System.Windows.Forms.Panel();
            this.pnlManagePlayers = new System.Windows.Forms.Panel();
            this.pnlManagePlayersLbl = new System.Windows.Forms.Panel();
            this.pnlGameCenter = new System.Windows.Forms.Panel();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.pnlUnoLbl = new System.Windows.Forms.Panel();
            this.pnlSelectPlayers.SuspendLayout();
            this.pnlSelectPlayersLbl.SuspendLayout();
            this.pnlManagePlayers.SuspendLayout();
            this.pnlManagePlayersLbl.SuspendLayout();
            this.pnlGameCenter.SuspendLayout();
            this.pnlUnoLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectPlayers
            // 
            this.lblSelectPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectPlayers.AutoSize = true;
            this.lblSelectPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPlayers.ForeColor = System.Drawing.Color.White;
            this.lblSelectPlayers.Location = new System.Drawing.Point(30, 30);
            this.lblSelectPlayers.Name = "lblSelectPlayers";
            this.lblSelectPlayers.Size = new System.Drawing.Size(116, 18);
            this.lblSelectPlayers.TabIndex = 6;
            this.lblSelectPlayers.Text = "Select Players";
            // 
            // ListBoxAvailablePlayers
            // 
            this.ListBoxAvailablePlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxAvailablePlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBoxAvailablePlayers.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxAvailablePlayers.FormattingEnabled = true;
            this.ListBoxAvailablePlayers.IntegralHeight = false;
            this.ListBoxAvailablePlayers.ItemHeight = 20;
            this.ListBoxAvailablePlayers.Location = new System.Drawing.Point(0, 78);
            this.ListBoxAvailablePlayers.Name = "ListBoxAvailablePlayers";
            this.ListBoxAvailablePlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxAvailablePlayers.Size = new System.Drawing.Size(176, 280);
            this.ListBoxAvailablePlayers.TabIndex = 0;
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))));
            this.BtnStartGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStartGame.FlatAppearance.BorderSize = 0;
            this.BtnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartGame.Location = new System.Drawing.Point(0, 78);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(217, 46);
            this.BtnStartGame.TabIndex = 1;
            this.BtnStartGame.Text = "Start Game!";
            this.BtnStartGame.UseVisualStyleBackColor = false;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.BtnAddPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddPlayer.FlatAppearance.BorderSize = 0;
            this.BtnAddPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(75)))));
            this.BtnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPlayer.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPlayer.ForeColor = System.Drawing.Color.White;
            this.BtnAddPlayer.Location = new System.Drawing.Point(0, 78);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(176, 39);
            this.BtnAddPlayer.TabIndex = 0;
            this.BtnAddPlayer.Text = "Add player";
            this.BtnAddPlayer.UseVisualStyleBackColor = false;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // BtnEditPlayer
            // 
            this.BtnEditPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.BtnEditPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditPlayer.FlatAppearance.BorderSize = 0;
            this.BtnEditPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(75)))));
            this.BtnEditPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditPlayer.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditPlayer.ForeColor = System.Drawing.Color.White;
            this.BtnEditPlayer.Location = new System.Drawing.Point(0, 156);
            this.BtnEditPlayer.Name = "BtnEditPlayer";
            this.BtnEditPlayer.Size = new System.Drawing.Size(176, 39);
            this.BtnEditPlayer.TabIndex = 2;
            this.BtnEditPlayer.Text = "Edit player";
            this.BtnEditPlayer.UseVisualStyleBackColor = false;
            this.BtnEditPlayer.Click += new System.EventHandler(this.BtnEditPlayer_Click);
            // 
            // BtnDeletePlayer
            // 
            this.BtnDeletePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.BtnDeletePlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeletePlayer.FlatAppearance.BorderSize = 0;
            this.BtnDeletePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(75)))));
            this.BtnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletePlayer.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletePlayer.ForeColor = System.Drawing.Color.White;
            this.BtnDeletePlayer.Location = new System.Drawing.Point(0, 195);
            this.BtnDeletePlayer.Name = "BtnDeletePlayer";
            this.BtnDeletePlayer.Size = new System.Drawing.Size(176, 39);
            this.BtnDeletePlayer.TabIndex = 3;
            this.BtnDeletePlayer.Text = "Delete player";
            this.BtnDeletePlayer.UseVisualStyleBackColor = false;
            this.BtnDeletePlayer.Click += new System.EventHandler(this.BtnDeletePlayer_Click);
            // 
            // BtnPlayerDetails
            // 
            this.BtnPlayerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.BtnPlayerDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlayerDetails.FlatAppearance.BorderSize = 0;
            this.BtnPlayerDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(75)))));
            this.BtnPlayerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayerDetails.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayerDetails.ForeColor = System.Drawing.Color.White;
            this.BtnPlayerDetails.Location = new System.Drawing.Point(0, 117);
            this.BtnPlayerDetails.Name = "BtnPlayerDetails";
            this.BtnPlayerDetails.Size = new System.Drawing.Size(176, 39);
            this.BtnPlayerDetails.TabIndex = 1;
            this.BtnPlayerDetails.Text = "Player Details";
            this.BtnPlayerDetails.UseVisualStyleBackColor = false;
            this.BtnPlayerDetails.Click += new System.EventHandler(this.BtnPlayerDetails_Click);
            // 
            // lblManagePlayers
            // 
            this.lblManagePlayers.AutoSize = true;
            this.lblManagePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePlayers.ForeColor = System.Drawing.Color.White;
            this.lblManagePlayers.Location = new System.Drawing.Point(23, 30);
            this.lblManagePlayers.Name = "lblManagePlayers";
            this.lblManagePlayers.Size = new System.Drawing.Size(128, 18);
            this.lblManagePlayers.TabIndex = 0;
            this.lblManagePlayers.Text = "Manage Players";
            // 
            // lblUno
            // 
            this.lblUno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.ForeColor = System.Drawing.Color.White;
            this.lblUno.Location = new System.Drawing.Point(0, 0);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(217, 78);
            this.lblUno.TabIndex = 5;
            this.lblUno.Text = "UNO!";
            this.lblUno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSelectPlayers
            // 
            this.pnlSelectPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.pnlSelectPlayers.Controls.Add(this.ListBoxAvailablePlayers);
            this.pnlSelectPlayers.Controls.Add(this.pnlSelectPlayersLbl);
            this.pnlSelectPlayers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSelectPlayers.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectPlayers.Name = "pnlSelectPlayers";
            this.pnlSelectPlayers.Size = new System.Drawing.Size(176, 341);
            this.pnlSelectPlayers.TabIndex = 10;
            // 
            // pnlSelectPlayersLbl
            // 
            this.pnlSelectPlayersLbl.Controls.Add(this.lblSelectPlayers);
            this.pnlSelectPlayersLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectPlayersLbl.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectPlayersLbl.Name = "pnlSelectPlayersLbl";
            this.pnlSelectPlayersLbl.Size = new System.Drawing.Size(176, 78);
            this.pnlSelectPlayersLbl.TabIndex = 1;
            // 
            // pnlManagePlayers
            // 
            this.pnlManagePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.pnlManagePlayers.Controls.Add(this.lblErrMsg);
            this.pnlManagePlayers.Controls.Add(this.BtnDeletePlayer);
            this.pnlManagePlayers.Controls.Add(this.BtnEditPlayer);
            this.pnlManagePlayers.Controls.Add(this.BtnPlayerDetails);
            this.pnlManagePlayers.Controls.Add(this.BtnAddPlayer);
            this.pnlManagePlayers.Controls.Add(this.pnlManagePlayersLbl);
            this.pnlManagePlayers.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlManagePlayers.Location = new System.Drawing.Point(393, 0);
            this.pnlManagePlayers.Name = "pnlManagePlayers";
            this.pnlManagePlayers.Size = new System.Drawing.Size(176, 341);
            this.pnlManagePlayers.TabIndex = 11;
            // 
            // pnlManagePlayersLbl
            // 
            this.pnlManagePlayersLbl.Controls.Add(this.lblManagePlayers);
            this.pnlManagePlayersLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManagePlayersLbl.Location = new System.Drawing.Point(0, 0);
            this.pnlManagePlayersLbl.Name = "pnlManagePlayersLbl";
            this.pnlManagePlayersLbl.Size = new System.Drawing.Size(176, 78);
            this.pnlManagePlayersLbl.TabIndex = 0;
            // 
            // pnlGameCenter
            // 
            this.pnlGameCenter.Controls.Add(this.BtnStartGame);
            this.pnlGameCenter.Controls.Add(this.pnlUnoLbl);
            this.pnlGameCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGameCenter.Location = new System.Drawing.Point(176, 0);
            this.pnlGameCenter.Name = "pnlGameCenter";
            this.pnlGameCenter.Size = new System.Drawing.Size(217, 341);
            this.pnlGameCenter.TabIndex = 12;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblErrMsg.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrMsg.Location = new System.Drawing.Point(0, 234);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(176, 107);
            this.lblErrMsg.TabIndex = 4;
            // 
            // pnlUnoLbl
            // 
            this.pnlUnoLbl.Controls.Add(this.lblUno);
            this.pnlUnoLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUnoLbl.Location = new System.Drawing.Point(0, 0);
            this.pnlUnoLbl.Name = "pnlUnoLbl";
            this.pnlUnoLbl.Size = new System.Drawing.Size(217, 78);
            this.pnlUnoLbl.TabIndex = 6;
            // 
            // GameMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(569, 341);
            this.Controls.Add(this.pnlGameCenter);
            this.Controls.Add(this.pnlManagePlayers);
            this.Controls.Add(this.pnlSelectPlayers);
            this.Name = "GameMainMenu";
            this.Text = "GameMainMenu";
            this.Load += new System.EventHandler(this.GameMainMenu_Load);
            this.pnlSelectPlayers.ResumeLayout(false);
            this.pnlSelectPlayersLbl.ResumeLayout(false);
            this.pnlSelectPlayersLbl.PerformLayout();
            this.pnlManagePlayers.ResumeLayout(false);
            this.pnlManagePlayersLbl.ResumeLayout(false);
            this.pnlManagePlayersLbl.PerformLayout();
            this.pnlGameCenter.ResumeLayout(false);
            this.pnlUnoLbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectPlayers;
        private System.Windows.Forms.ListBox ListBoxAvailablePlayers;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Button BtnAddPlayer;
        private System.Windows.Forms.Button BtnEditPlayer;
        private System.Windows.Forms.Button BtnDeletePlayer;
        private System.Windows.Forms.Label lblManagePlayers;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Button BtnPlayerDetails;
        private System.Windows.Forms.Panel pnlSelectPlayers;
        private System.Windows.Forms.Panel pnlSelectPlayersLbl;
        private System.Windows.Forms.Panel pnlManagePlayers;
        private System.Windows.Forms.Panel pnlManagePlayersLbl;
        private System.Windows.Forms.Panel pnlGameCenter;
        private System.Windows.Forms.Label lblErrMsg;
        private System.Windows.Forms.Panel pnlUnoLbl;
    }
}