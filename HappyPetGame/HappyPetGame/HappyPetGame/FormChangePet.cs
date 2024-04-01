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
    public partial class FormChangePet : Form
    {
        FormGame frmGame;
        public FormChangePet()
        {
            InitializeComponent();
        }

        private void FormChangePet_Load(object sender, EventArgs e)
        {
            radioButtonCat.Checked = true;

            comboBoxEnvironment.Items.Add("River");
            comboBoxEnvironment.Items.Add("Sea");
            comboBoxEnvironment.Items.Add("Pond");
            comboBoxEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            frmGame = (FormGame)this.Owner;
        }

        private void buttonLetsPlay_Click(object sender, EventArgs e)
        {
            frmGame.listPet.Clear();
            if (radioButtonCat.Checked)
            {
                frmGame.myPet = new Cat(textBoxPetName.Text, radioButtonCat.BackgroundImage,
                                       frmGame.myPlayer, false);
            }
            else if (radioButtonFish.Checked)
            {
                frmGame.myPet = new Fish(textBoxPetName.Text, radioButtonFish.BackgroundImage,
                                        frmGame.myPlayer, comboBoxEnvironment.Text);
            }
            else if (radioButtonChameleon.Checked)
            {
                frmGame.myPet = new Chameleon(textBoxPetName.Text,
                                              radioButtonChameleon.BackgroundImage,
                                              frmGame.myPlayer, Color.Green);
            }
            //mulai permainan
            frmGame.StartGame();

            //simpan ke listnya
            frmGame.listPet.Add(frmGame.myPet);
            //tutup form selectpetnya 
            this.Close();
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = true;
            comboBoxEnvironment.Visible = true;
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }
    }
}
