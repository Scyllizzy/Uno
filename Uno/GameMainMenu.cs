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
            List<Player> allPlayers = PlayerDb.GetAllPlayers();
            ListBoxAvailablePlayers.DataSource = allPlayers;
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayer = new AddPlayerForm();
            addPlayer.ShowDialog();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            List<Player> selectedPlayers = new List<Player>();
            foreach (Player p in ListBoxAvailablePlayers.SelectedItems)
            {
                selectedPlayers.Add(p);
            }
            MessageBox.Show(string.Join(", ", selectedPlayers));
        }
    }
}
