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
            lblErrMsg.Text = "";
            PopulatePlayerList();
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            lblErrMsg.Text = "";
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
            lblErrMsg.Text = "";
            List<Player> selectedPlayers = new List<Player>();
            foreach (Player p in ListBoxAvailablePlayers.SelectedItems)
            {
                selectedPlayers.Add(p);
            }
            MessageBox.Show(string.Join(" vs ", selectedPlayers));
            FrmUno game = new FrmUno();
            game.ShowDialog();
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (ListBoxAvailablePlayers.SelectedItems.Count == 0)
            {
                lblErrMsg.Text = "Select the player(s)\nyou want to delete.";
            }
            else if (ListBoxAvailablePlayers.SelectedItems.Count > 3)
            {
                lblErrMsg.Text = "Can't delete more\nthan 3 players at\na time.";
            }
            else
            {
                lblErrMsg.Text = "";
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

        private void PopulatePlayerList()
        {
            List<Player> allPlayers = PlayerDb.GetAllPlayers();
            ListBoxAvailablePlayers.Items.Clear();
            foreach (Player p in allPlayers)
            {
                ListBoxAvailablePlayers.Items.Add(p);
            }
        }

        private void BtnEditPlayer_Click(object sender, EventArgs e)
        {
            lblErrMsg.Text = "";
            if (ListBoxAvailablePlayers.SelectedItems.Count < 1)
            {
                lblErrMsg.Text = "Select the player\nyou want to edit.";
            }
            else if (ListBoxAvailablePlayers.SelectedItems.Count > 1)
            {
                lblErrMsg.Text = "Can only edit 1\nplayer at a time.";
            }
            else
            {
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
            lblErrMsg.Text = "";
            if (ListBoxAvailablePlayers.SelectedItems.Count < 1)
            {
                lblErrMsg.Text = "Select the player\nyou want to view\nthe details of.";
            }
            else if (ListBoxAvailablePlayers.SelectedItems.Count > 1)
            {
                lblErrMsg.Text = "Can only view 1\nplayer's details\nat a time.";
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
