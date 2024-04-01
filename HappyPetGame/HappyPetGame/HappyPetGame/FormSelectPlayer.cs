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
    public partial class FormSelectPlayer : Form
    {
        FormGame frmGame;
        public FormSelectPlayer()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectPet frmSelectPet = new FormSelectPet();
            frmSelectPet.Owner = this;
            frmSelectPet.ShowDialog();
        }

        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
            comboBoxPlayer.DataSource = frmGame.listPlayer;
            comboBoxPlayer.DisplayMember = "Name";
            comboBoxPlayer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonLetsPlay_Click(object sender, EventArgs e)
        {
            frmGame.myPlayer = (Player)comboBoxPlayer.SelectedItem;

            foreach(Pet p in frmGame.listPet)
            {
                if(p.Owner.Name == frmGame.myPlayer.Name)
                {
                    frmGame.myPet = p;
                }
            }
            frmGame.StartGame();
            this.Close();
        }
    }
}
