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
    public partial class FormSelectPet : Form
    {
        FormGame frmGame;
        public FormSelectPet()
        {
            InitializeComponent();
        }

        private void FormSelectPet_Load(object sender, EventArgs e)
        {
            radioButtonCat.Checked = true;

            //background image bisa pakai coding bisa pakai langsun di setting di designnya
            //radioButtonCat.BackgroundImage = Properties.Resources.cat_happy;
            //radioButtonFish.BackgroundImage = Properties.Resources.fish_happy;
            //radioButtonChameleon.BackgroundImage = Properties.Resources.chameleon_happy;
            //radioButtonCat.BackgroundImageLayout = ImageLayout.Stretch;
            //radioButtonFish.BackgroundImageLayout = ImageLayout.Stretch;
            //radioButtonChameleon.BackgroundImageLayout = ImageLayout.Stretch;

            comboBoxEnvironment.Items.Add("River");
            comboBoxEnvironment.Items.Add("Sea");
            comboBoxEnvironment.Items.Add("Pond");
            comboBoxEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            frmGame = (FormGame)this.Owner.Owner;

        }

        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = true;
            comboBoxEnvironment.Visible = true;
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void buttonLetsPlay_Click(object sender, EventArgs e)
        {
            
            
            frmGame.myPlayer = new Player(textBoxPlayerName.Text, 100, DateTime.Now);
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
                                              frmGame.myPlayer,Color.Green);
            }

            //mulai permainan
            frmGame.StartGame();

            //simpan ke listnya
            frmGame.listPlayer.Add(frmGame.myPlayer);
            frmGame.listPet.Add(frmGame.myPet);
            //tutup form selectpetnya 
            this.Close();
            this.Owner.Close();


        }
    }
}
