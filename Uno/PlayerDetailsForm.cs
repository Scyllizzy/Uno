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
    public partial class PlayerDetailsForm : Form
    {
        private readonly Player P;
        public PlayerDetailsForm(Player p)
        {
            P = p;
            InitializeComponent();
        }

        private void PlayerDetailsForm_Load(object sender, EventArgs e)
        {
            lblHeader.Text = $"{P.UserName}'s stats";
            lblWinsCount.Text += $" {P.Win}";
            lblLossCount.Text += $" {P.Loss}";
            lblWinLoss.Text += $" {P.WinLossRatio()}";
            lblTotalGamesPlayed.Text += $" {P.Win + P.Loss}";
        }

        private void BtnBackMainMenu_Click(object sender, EventArgs e)
        {
            BtnBackMainMenu.DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
