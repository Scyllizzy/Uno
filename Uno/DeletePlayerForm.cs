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
    public partial class DeletePlayerForm : Form
    {
        private List<Player> playersToBeDeleted;
        public DeletePlayerForm(List<Player> selectedPlayers)
        {
            playersToBeDeleted = selectedPlayers;
            InitializeComponent();
        }

        private void DeletePlayerForm_Load(object sender, EventArgs e)
        {
            if (playersToBeDeleted.Count > 1)
            {
                lblDeleteHeader.Text = "Delete these players?!";
                lblDeleteHeader.Left = 70;
                lblPlayerName.Left = 80;
            }
            lblPlayerName.Text = string.Join(", ", playersToBeDeleted);
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            btnDeletePlayer.DialogResult = DialogResult.Yes;
            lblDeleteHeader.ForeColor = Color.Green;
            lblDeleteHeader.Text = $"{string.Join(" & ", playersToBeDeleted)} has been deleted!";
            foreach (Player player in playersToBeDeleted)
            {
                PlayerDb.Delete(player);
            }
            Timer timer = new Timer(); // Auto close form after 2 seconds.
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        /// <summary>
        /// Closes form 2 seconds after successful form validation.
        /// </summary>
        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
