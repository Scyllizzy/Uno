using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class EditPlayerForm : Form
    {
        private readonly Player P;
        public EditPlayerForm(Player p)
        {
            P = p;
            InitializeComponent();
        }

        private void EditPlayerForm_Load(object sender, EventArgs e)
        {
            lblEditPlayerHeader.Text = $"Edit {P}";
            txtboxFName.Text = P.FirstName;
            txtboxLName.Text = P.LastName;
            txtboxEmail.Text = P.Email;
            txtboxUsername.Text = P.UserName;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidateFormInput())
            {
                btnSaveChanges.DialogResult = DialogResult.Yes;
                P.FirstName = txtboxFName.Text;
                P.LastName = txtboxLName.Text;
                P.Email = txtboxEmail.Text;
                P.UserName = txtboxUsername.Text;
                PlayerDb.Update(P);
                lblEditPlayerHeader.ForeColor = Color.Green;
                lblEditPlayerHeader.Text = "Saved changes!";
                Timer timer = new Timer(); // Auto close form after 2 seconds.
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
        }

        /// <summary>
        /// Closes form 2 seconds after successful form validation.
        /// </summary>
        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFormInput()
        {
            lblFNameErrMsg.Text = "*";
            lblLNameErrMsg.Text = "*";
            lblEmailErrMsg.Text = "*";
            lblUsernameErrMsg.Text = "*";
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtboxFName.Text))
            {
                lblFNameErrMsg.Text = "1-25 characters";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtboxLName.Text))
            {
                lblLNameErrMsg.Text = "1-25 characters";
                isValid = false;
            }
            int index = txtboxEmail.Text.IndexOf('@');
            if (string.IsNullOrWhiteSpace(txtboxEmail.Text) ||     // if user entered spaces or nothing
                index < 1 ||                                    // if @ is first character
                txtboxEmail.Text.LastIndexOf('.') < index + 2 ||   // if . is before @ or there's no character between them
                txtboxEmail.Text.LastIndexOf('.') == txtboxEmail.Text.Length - 1)   // if . is last character
            {
                lblEmailErrMsg.Text = "must contain @ and .";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtboxUsername.Text) || txtboxUsername.Text.Length < 5)
            {
                lblUsernameErrMsg.Text = "6-15 characters";
                isValid = false;
            }
            return isValid;
        }
    }
}
