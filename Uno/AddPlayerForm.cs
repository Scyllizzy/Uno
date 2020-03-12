using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Uno
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        public Player NewPlayer { get; set; }

        private void BtnSubmitAdd_Click(object sender, EventArgs e)
        {
            
            if (ValidateFormInput())
            {
                BtnSubmitAdd.DialogResult = DialogResult.Yes;
                Player p = new Player()
                {
                    FirstName = TxtFirstName.Text,
                    LastName = TxtLastName.Text,
                    UserName = TxtUsername.Text,
                    Email = TxtEmail.Text.ToLower()
                };
                NewPlayer = p;
                lblAddResult.ForeColor = Color.Green;
                lblAddResult.Text = $"{p.UserName} can now play Uno!";
                PlayerDb.Add(p);
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
            if (string.IsNullOrWhiteSpace(TxtFirstName.Text))
            {
                lblFNameErrMsg.Text = "1-25 characters";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TxtLastName.Text))
            {
                lblLNameErrMsg.Text = "1-25 characters";
                isValid = false;
            }
            int index = TxtEmail.Text.IndexOf('@');
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) ||     // if user entered spaces or nothing
                index < 1 ||                                    // if @ is first character
                TxtEmail.Text.LastIndexOf('.') < index + 2 ||   // if . is before @ or there's no character between them
                TxtEmail.Text.LastIndexOf('.') == TxtEmail.Text.Length-1)   // if . is last character
            {
                lblEmailErrMsg.Text = "must contain @ and .";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TxtUsername.Text) || TxtUsername.Text.Length < 5)
            {
                lblUsernameErrMsg.Text = "6-15 characters";
                isValid = false;
            }
            return isValid;
        }
    }
}
