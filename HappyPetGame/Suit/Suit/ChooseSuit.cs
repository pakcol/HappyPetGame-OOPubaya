using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suit
{
    public partial class ChooseSuit : Form
    {
        BattleMenu battleMenu;
        public string playerSuit = "";
        public ChooseSuit()
        {
            InitializeComponent();
        }

        private void ButtonLetsPlay_Click(object sender, EventArgs e)
        {
            if (radioButtonBatu.Checked)
            {
                playerSuit = "Batu";
            }
            else if (radioButtonGunting.Checked)
            {
                playerSuit = "Gunting";
            }
            else if (radioButtonKertas.Checked)
            {
                playerSuit = "Kertas";
            }
            BattleMenu form = new BattleMenu();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ChooseSuit_Load(object sender, EventArgs e)
        {
            battleMenu = (BattleMenu)this.Owner;
        }
    }
}
