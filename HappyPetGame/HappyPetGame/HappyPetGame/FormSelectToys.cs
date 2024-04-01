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
    public partial class FormSelectToys : Form
    {
        FormGame frmGame;
        Toy selectedToy;
        public FormSelectToys()
        {
            InitializeComponent();
        }

        private void FormSelectToys_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
            comboBoxToys.DataSource = frmGame.myPet.ListToys;
            comboBoxToys.DisplayMember = "Name";
            comboBoxToys.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void linkLabelBuyToys_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormToysShop frmToyShop = new FormToysShop();
            frmToyShop.Owner = this;
            frmToyShop.ShowDialog();
        }

        private void comboBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxToys.SelectedIndex != -1)
            {
                selectedToy = (Toy)comboBoxToys.SelectedItem;

                pictureBoxToys.Image = selectedToy.Picture;
                pictureBoxToys.SizeMode = PictureBoxSizeMode.StretchImage;
                labelToysData.Text = selectedToy.DisplayData();
            }

        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            frmGame.myPet.Play(selectedToy);

            frmGame.labelPetData.Text = frmGame.myPet.DisplayData();

            frmGame.timerGame.Enabled = true;
            
            this.Close();
        }

        private void FormSelectToys_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmGame.timerGame.Enabled = true;
        }
    }
}
