using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame
{
    public partial class FormChooseSuit : Form
    {
        FormSelectMinigames frmSuit;
        public string playerSuit = "";
        public FormChooseSuit()
        {
            InitializeComponent();
        }

        private void FormChooseSuit_Load(object sender, EventArgs e)
        {
            frmSuit = (FormSelectMinigames)this.Owner;

        }

        private void buttonLetsPlay_Click(object sender, EventArgs e)
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
            FormSuit form = new FormSuit();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
