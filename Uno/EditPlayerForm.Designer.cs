namespace Uno
{
    partial class EditPlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxFName = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxLName = new System.Windows.Forms.TextBox();
            this.lblEditPlayerHeader = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblFNameErrMsg = new System.Windows.Forms.Label();
            this.lblLNameErrMsg = new System.Windows.Forms.Label();
            this.lblUsernameErrMsg = new System.Windows.Forms.Label();
            this.lblEmailErrMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // txtboxFName
            // 
            this.txtboxFName.Location = new System.Drawing.Point(87, 58);
            this.txtboxFName.Name = "txtboxFName";
            this.txtboxFName.Size = new System.Drawing.Size(199, 20);
            this.txtboxFName.TabIndex = 0;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(87, 145);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(199, 20);
            this.txtboxEmail.TabIndex = 3;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(87, 116);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(199, 20);
            this.txtboxUsername.TabIndex = 2;
            // 
            // txtboxLName
            // 
            this.txtboxLName.Location = new System.Drawing.Point(87, 87);
            this.txtboxLName.Name = "txtboxLName";
            this.txtboxLName.Size = new System.Drawing.Size(199, 20);
            this.txtboxLName.TabIndex = 1;
            // 
            // lblEditPlayerHeader
            // 
            this.lblEditPlayerHeader.AutoSize = true;
            this.lblEditPlayerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPlayerHeader.Location = new System.Drawing.Point(43, 19);
            this.lblEditPlayerHeader.Name = "lblEditPlayerHeader";
            this.lblEditPlayerHeader.Size = new System.Drawing.Size(123, 24);
            this.lblEditPlayerHeader.TabIndex = 10;
            this.lblEditPlayerHeader.Text = "PlayerName";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(87, 185);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(199, 27);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblFNameErrMsg
            // 
            this.lblFNameErrMsg.AutoSize = true;
            this.lblFNameErrMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFNameErrMsg.Location = new System.Drawing.Point(286, 61);
            this.lblFNameErrMsg.Name = "lblFNameErrMsg";
            this.lblFNameErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblFNameErrMsg.TabIndex = 12;
            this.lblFNameErrMsg.Text = "*";
            // 
            // lblLNameErrMsg
            // 
            this.lblLNameErrMsg.AutoSize = true;
            this.lblLNameErrMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLNameErrMsg.Location = new System.Drawing.Point(286, 90);
            this.lblLNameErrMsg.Name = "lblLNameErrMsg";
            this.lblLNameErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblLNameErrMsg.TabIndex = 13;
            this.lblLNameErrMsg.Text = "*";
            // 
            // lblUsernameErrMsg
            // 
            this.lblUsernameErrMsg.AutoSize = true;
            this.lblUsernameErrMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsernameErrMsg.Location = new System.Drawing.Point(286, 119);
            this.lblUsernameErrMsg.Name = "lblUsernameErrMsg";
            this.lblUsernameErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblUsernameErrMsg.TabIndex = 14;
            this.lblUsernameErrMsg.Text = "*";
            // 
            // lblEmailErrMsg
            // 
            this.lblEmailErrMsg.AutoSize = true;
            this.lblEmailErrMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmailErrMsg.Location = new System.Drawing.Point(286, 148);
            this.lblEmailErrMsg.Name = "lblEmailErrMsg";
            this.lblEmailErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblEmailErrMsg.TabIndex = 15;
            this.lblEmailErrMsg.Text = "*";
            // 
            // EditPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 238);
            this.Controls.Add(this.lblEmailErrMsg);
            this.Controls.Add(this.lblUsernameErrMsg);
            this.Controls.Add(this.lblLNameErrMsg);
            this.Controls.Add(this.lblFNameErrMsg);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblEditPlayerHeader);
            this.Controls.Add(this.txtboxLName);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPlayerForm";
            this.Text = "EditPlayerForm";
            this.Load += new System.EventHandler(this.EditPlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxFName;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxLName;
        private System.Windows.Forms.Label lblEditPlayerHeader;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblFNameErrMsg;
        private System.Windows.Forms.Label lblLNameErrMsg;
        private System.Windows.Forms.Label lblUsernameErrMsg;
        private System.Windows.Forms.Label lblEmailErrMsg;
    }
}