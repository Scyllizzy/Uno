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
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void BtnSubmitAdd_Click(object sender, EventArgs e)
        {
            Player p = new Player()
            {
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                UserName = TxtUsername.Text,
                Email = TxtEmail.Text.ToLower()
            };
            PlayerDb.Add(p);
        }
    }
}
