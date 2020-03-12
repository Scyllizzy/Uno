namespace Uno
{
    partial class AddPlayerForm
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
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.BtnSubmitAdd = new System.Windows.Forms.Button();
            this.lblFNameErrMsg = new System.Windows.Forms.Label();
            this.lblLNameErrMsg = new System.Windows.Forms.Label();
            this.lblUsernameErrMsg = new System.Windows.Forms.Label();
            this.lblEmailErrMsg = new System.Windows.Forms.Label();
            this.lblAddResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(21, 37);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(58, 13);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First name:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(20, 66);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(59, 13);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Last name:";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(21, 95);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(58, 13);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "Username:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(44, 124);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(81, 33);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(173, 20);
            this.TxtFirstName.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(81, 120);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(173, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(81, 91);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(173, 20);
            this.TxtUsername.TabIndex = 6;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(81, 62);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(173, 20);
            this.TxtLastName.TabIndex = 7;
            // 
            // BtnSubmitAdd
            // 
            this.BtnSubmitAdd.Location = new System.Drawing.Point(81, 157);
            this.BtnSubmitAdd.Name = "BtnSubmitAdd";
            this.BtnSubmitAdd.Size = new System.Drawing.Size(173, 30);
            this.BtnSubmitAdd.TabIndex = 8;
            this.BtnSubmitAdd.Text = "Add Player!";
            this.BtnSubmitAdd.UseVisualStyleBackColor = true;
            this.BtnSubmitAdd.Click += new System.EventHandler(this.BtnSubmitAdd_Click);
            // 
            // lblFNameErrMsg
            // 
            this.lblFNameErrMsg.AutoSize = true;
            this.lblFNameErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblFNameErrMsg.Location = new System.Drawing.Point(254, 37);
            this.lblFNameErrMsg.Name = "lblFNameErrMsg";
            this.lblFNameErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblFNameErrMsg.TabIndex = 9;
            this.lblFNameErrMsg.Text = "*";
            // 
            // lblLNameErrMsg
            // 
            this.lblLNameErrMsg.AutoSize = true;
            this.lblLNameErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblLNameErrMsg.Location = new System.Drawing.Point(254, 65);
            this.lblLNameErrMsg.Name = "lblLNameErrMsg";
            this.lblLNameErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblLNameErrMsg.TabIndex = 10;
            this.lblLNameErrMsg.Text = "*";
            // 
            // lblUsernameErrMsg
            // 
            this.lblUsernameErrMsg.AutoSize = true;
            this.lblUsernameErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameErrMsg.Location = new System.Drawing.Point(254, 94);
            this.lblUsernameErrMsg.Name = "lblUsernameErrMsg";
            this.lblUsernameErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblUsernameErrMsg.TabIndex = 11;
            this.lblUsernameErrMsg.Text = "*";
            // 
            // lblEmailErrMsg
            // 
            this.lblEmailErrMsg.AutoSize = true;
            this.lblEmailErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblEmailErrMsg.Location = new System.Drawing.Point(254, 124);
            this.lblEmailErrMsg.Name = "lblEmailErrMsg";
            this.lblEmailErrMsg.Size = new System.Drawing.Size(11, 13);
            this.lblEmailErrMsg.TabIndex = 12;
            this.lblEmailErrMsg.Text = "*";
            // 
            // lblAddResult
            // 
            this.lblAddResult.AutoSize = true;
            this.lblAddResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddResult.ForeColor = System.Drawing.Color.Black;
            this.lblAddResult.Location = new System.Drawing.Point(69, 199);
            this.lblAddResult.Name = "lblAddResult";
            this.lblAddResult.Size = new System.Drawing.Size(21, 20);
            this.lblAddResult.TabIndex = 13;
            this.lblAddResult.Text = "...";
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 231);
            this.Controls.Add(this.lblAddResult);
            this.Controls.Add(this.lblEmailErrMsg);
            this.Controls.Add(this.lblUsernameErrMsg);
            this.Controls.Add(this.lblLNameErrMsg);
            this.Controls.Add(this.lblFNameErrMsg);
            this.Controls.Add(this.BtnSubmitAdd);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Button BtnSubmitAdd;
        private System.Windows.Forms.Label lblFNameErrMsg;
        private System.Windows.Forms.Label lblLNameErrMsg;
        private System.Windows.Forms.Label lblUsernameErrMsg;
        private System.Windows.Forms.Label lblEmailErrMsg;
        private System.Windows.Forms.Label lblAddResult;
    }
}