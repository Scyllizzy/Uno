﻿namespace Uno
{
    partial class DeletePlayerForm
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
            this.lblDeleteHeader = new System.Windows.Forms.Label();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeleteHeader
            // 
            this.lblDeleteHeader.AutoEllipsis = true;
            this.lblDeleteHeader.AutoSize = true;
            this.lblDeleteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeleteHeader.Location = new System.Drawing.Point(93, 20);
            this.lblDeleteHeader.Name = "lblDeleteHeader";
            this.lblDeleteHeader.Size = new System.Drawing.Size(182, 24);
            this.lblDeleteHeader.TabIndex = 0;
            this.lblDeleteHeader.Text = "Delete this player?";
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(52, 98);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(115, 34);
            this.btnDeletePlayer.TabIndex = 1;
            this.btnDeletePlayer.Text = "Delete Forever";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.BtnDeletePlayer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Don\'t Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(149, 60);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(100, 18);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "PlayerName";
            // 
            // DeletePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 162);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.lblDeleteHeader);
            this.Name = "DeletePlayerForm";
            this.Text = "DeletePlayerForm";
            this.Load += new System.EventHandler(this.DeletePlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteHeader;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPlayerName;
    }
}