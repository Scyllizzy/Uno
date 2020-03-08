using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uno.Properties;

namespace Uno
{
    public partial class FrmUno : Form
    {
        public FrmUno()
        {
            InitializeComponent();
            // When you first boot up the game,
            // the pause screen & ready button will be hidden until
            // turns change or players hit the pause button.
            PcbxPauseGif.Visible = false;
            BtnNextTurn.Visible = false;
            BtnUnPause.Visible = false;
            PcbxPauseGif.Image = Resources.Kitty;
            PcbxPauseGif.BringToFront();
        }

        /// <summary>
        /// When clicked, the game is paused, making the
        /// pause screen and UnPause button visible.
        /// </summary>
        private void BtnPause_Click(object sender, EventArgs e)
        {
            PcbxPauseGif.Visible = true;
            // This needs to be after PcbxPauseGif.Visible = true;
            // otherwise, the UnPause button doesn't appear
            BtnUnPause.BringToFront(); 
            BtnUnPause.Visible = true;
            BtnPause.Visible = false;
        }
        /// <summary>
        /// When clicked, the game is un-paused, making the
        /// pause screen not visible, and the pause button visible again.
        /// </summary>
        private void BtnUnPause_Click(object sender, EventArgs e)
        {
            BtnPause.Visible = true;
            BtnUnPause.Visible = false;
            PcbxPauseGif.Visible = false;
        }

        private void FrmUno_Load(object sender, EventArgs e)
        {
            var list = Deck.CreateDeck();
            listBoxDeck.DataSource = list;
        }
    }
}
