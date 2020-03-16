namespace Uno
{
    partial class FrmUno
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
            this.PcbxPauseGif = new System.Windows.Forms.PictureBox();
            this.BtnNextTurn = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnUnPause = new System.Windows.Forms.Button();
            this.listBoxDeck = new System.Windows.Forms.ListBox();
            this.listBoxDiscardPile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcbxPauseGif)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbxPauseGif
            // 
            this.PcbxPauseGif.Location = new System.Drawing.Point(-1, -4);
            this.PcbxPauseGif.Margin = new System.Windows.Forms.Padding(4);
            this.PcbxPauseGif.Name = "PcbxPauseGif";
            this.PcbxPauseGif.Size = new System.Drawing.Size(1721, 886);
            this.PcbxPauseGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PcbxPauseGif.TabIndex = 0;
            this.PcbxPauseGif.TabStop = false;
            // 
            // BtnNextTurn
            // 
            this.BtnNextTurn.Location = new System.Drawing.Point(1553, 805);
            this.BtnNextTurn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNextTurn.Name = "BtnNextTurn";
            this.BtnNextTurn.Size = new System.Drawing.Size(120, 42);
            this.BtnNextTurn.TabIndex = 1;
            this.BtnNextTurn.Text = "Ready";
            this.BtnNextTurn.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(1575, 15);
            this.BtnPause.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(120, 42);
            this.BtnPause.TabIndex = 2;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnUnPause
            // 
            this.BtnUnPause.Location = new System.Drawing.Point(1575, 15);
            this.BtnUnPause.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUnPause.Name = "BtnUnPause";
            this.BtnUnPause.Size = new System.Drawing.Size(120, 42);
            this.BtnUnPause.TabIndex = 3;
            this.BtnUnPause.Text = "UnPause";
            this.BtnUnPause.UseVisualStyleBackColor = true;
            this.BtnUnPause.Click += new System.EventHandler(this.BtnUnPause_Click);
            // 
            // listBoxDeck
            // 
            this.listBoxDeck.FormattingEnabled = true;
            this.listBoxDeck.ItemHeight = 16;
            this.listBoxDeck.Location = new System.Drawing.Point(625, 272);
            this.listBoxDeck.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDeck.Name = "listBoxDeck";
            this.listBoxDeck.Size = new System.Drawing.Size(171, 276);
            this.listBoxDeck.TabIndex = 4;
            // 
            // listBoxDiscardPile
            // 
            this.listBoxDiscardPile.FormattingEnabled = true;
            this.listBoxDiscardPile.ItemHeight = 16;
            this.listBoxDiscardPile.Location = new System.Drawing.Point(829, 272);
            this.listBoxDiscardPile.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDiscardPile.Name = "listBoxDiscardPile";
            this.listBoxDiscardPile.Size = new System.Drawing.Size(171, 276);
            this.listBoxDiscardPile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Deck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Discard Pile";
            // 
            // BtnUno
            // 
            this.BtnUno.Enabled = false;
            this.BtnUno.Location = new System.Drawing.Point(737, 573);
            this.BtnUno.Name = "BtnUno";
            this.BtnUno.Size = new System.Drawing.Size(133, 55);
            this.BtnUno.TabIndex = 8;
            this.BtnUno.Text = "Uno";
            this.BtnUno.UseVisualStyleBackColor = true;
            this.BtnUno.Visible = false;
            this.BtnUno.Click += new System.EventHandler(this.UnoButtonClick);
            // 
            // FrmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 875);
            this.Controls.Add(this.BtnUno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDiscardPile);
            this.Controls.Add(this.listBoxDeck);
            this.Controls.Add(this.BtnUnPause);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnNextTurn);
            this.Controls.Add(this.PcbxPauseGif);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUno";
            this.Text = "Uno!";
            this.Load += new System.EventHandler(this.FrmUno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbxPauseGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbxPauseGif;
        private System.Windows.Forms.Button BtnNextTurn;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnUnPause;
        private System.Windows.Forms.ListBox listBoxDeck;
        private System.Windows.Forms.ListBox listBoxDiscardPile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUno;
    }
}

