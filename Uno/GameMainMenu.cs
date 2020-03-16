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
    public partial class GameMainMenu : Form
    {
        public GameMainMenu()
        {
            InitializeComponent();
        }

        private void GameMainMenu_Load(object sender, EventArgs e)
        {
            PopulatePlayerList();
        }

        /// <summary>
        /// Populates the list of players with players from the database.
        /// </summary>
        private void PopulatePlayerList()
        {
            List<Player> allPlayers = PlayerDb.GetAllPlayers();
            ListBoxAvailablePlayers.Items.Clear();
            foreach (Player p in allPlayers)
            {
                ListBoxAvailablePlayers.Items.Add(p);
            }
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayer = new AddPlayerForm();
            DialogResult result = addPlayer.ShowDialog();
            if (result == DialogResult.Yes)
            {
                Player p = addPlayer.NewPlayer;
                ListBoxAvailablePlayers.Items.Add(p);
            }

            PopulatePlayerList();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            int selectedCount = ListBoxAvailablePlayers.SelectedItems.Count;

            if (selectedCount < 2 || selectedCount > 4)
            {
                lblErrMsg.Text = "You must select 2-4 players.";
            }
            else
            {
                lblErrMsg.Text = string.Empty;
                List<Player> selectedPlayers = new List<Player>();

                foreach (Player p in ListBoxAvailablePlayers.SelectedItems)
                {
                    selectedPlayers.Add(p);
                }

                MessageBox.Show(string.Join(" vs ", selectedPlayers));
                FrmUno game = new FrmUno();
                game.ShowDialog();
            }
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            int selectedCount = ListBoxAvailablePlayers.SelectedItems.Count;

            if (selectedCount == 0)
            {
                lblErrMsg.Text = "Select the player or players you want to delete.";
            }
            else if (selectedCount > 3)
            {
                lblErrMsg.Text = "Can't delete more than 3 players at a time.";
            }
            else
            {
                lblErrMsg.Text = string.Empty;

                List<Player> selectedPlayers = new List<Player>();
                foreach (Player p in ListBoxAvailablePlayers.SelectedItems)
                {
                    selectedPlayers.Add(p);
                }
                DeletePlayerForm deletePlayer = new DeletePlayerForm(selectedPlayers);
                DialogResult result = deletePlayer.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    ListBoxAvailablePlayers.Items.Remove(ListBoxAvailablePlayers.SelectedItem);
                }
                PopulatePlayerList();
            }
        }

        private void BtnEditPlayer_Click(object sender, EventArgs e)
        {
            int selectedCount = ListBoxAvailablePlayers.SelectedItems.Count;

            if (selectedCount < 1)
            {
                lblErrMsg.Text = "Select the player you want to edit.";
            }
            else if (selectedCount > 1)
            {
                lblErrMsg.Text = "Can only edit 1 player at a time.";
            }
            else
            {
                lblErrMsg.Text = string.Empty;

                Player p = (Player)ListBoxAvailablePlayers.SelectedItem;
                EditPlayerForm editPlayer = new EditPlayerForm(p);
                DialogResult result = editPlayer.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    PopulatePlayerList();
                }
            }
        }

        private void BtnPlayerDetails_Click(object sender, EventArgs e)
        {
            int selectedCount = ListBoxAvailablePlayers.SelectedItems.Count;

            lblErrMsg.Text = string.Empty;
            if (selectedCount < 1)
            {
                lblErrMsg.Text = "Select the player you want to view the details of.";
            }
            else if (selectedCount > 1)
            {
                lblErrMsg.Text = "Can only view 1 player's details at a time.";
            }
            else
            {
                Player p = (Player)ListBoxAvailablePlayers.SelectedItem;
                PlayerDetailsForm playerDetails = new PlayerDetailsForm(p);
                DialogResult result = playerDetails.ShowDialog();
            }
        }
    }
}
