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
            PcbxPauseGif.Image = Resources.Kitty;
        }
    }
}
