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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcbxPauseGif)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbxPauseGif
            // 
            this.PcbxPauseGif.Location = new System.Drawing.Point(-1, 0);
            this.PcbxPauseGif.Name = "PcbxPauseGif";
            this.PcbxPauseGif.Size = new System.Drawing.Size(1284, 710);
            this.PcbxPauseGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PcbxPauseGif.TabIndex = 0;
            this.PcbxPauseGif.TabStop = false;
            // 
            // BtnNextTurn
            // 
            this.BtnNextTurn.Location = new System.Drawing.Point(1165, 654);
            this.BtnNextTurn.Name = "BtnNextTurn";
            this.BtnNextTurn.Size = new System.Drawing.Size(90, 34);
            this.BtnNextTurn.TabIndex = 1;
            this.BtnNextTurn.Text = "Ready";
            this.BtnNextTurn.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(1181, 12);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(90, 34);
            this.BtnPause.TabIndex = 2;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnUnPause
            // 
            this.BtnUnPause.Location = new System.Drawing.Point(1181, 12);
            this.BtnUnPause.Name = "BtnUnPause";
            this.BtnUnPause.Size = new System.Drawing.Size(90, 34);
            this.BtnUnPause.TabIndex = 3;
            this.BtnUnPause.Text = "UnPause";
            this.BtnUnPause.UseVisualStyleBackColor = true;
            this.BtnUnPause.Click += new System.EventHandler(this.BtnUnPause_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(979, 440);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUnPause);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnNextTurn);
            this.Controls.Add(this.PcbxPauseGif);
            this.Name = "FrmUno";
            this.Text = "Uno!";
            ((System.ComponentModel.ISupportInitialize)(this.PcbxPauseGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbxPauseGif;
        private System.Windows.Forms.Button BtnNextTurn;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnUnPause;
        private System.Windows.Forms.Button button1;
    }
}

