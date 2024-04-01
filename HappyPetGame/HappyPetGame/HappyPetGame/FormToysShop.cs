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
    public partial class FormToysShop : Form
    {
        List<Toy> listToys = new List<Toy>();
        Toy toy1, toy2, toy3;
        FormGame frmGame;
        public FormToysShop()
        {
            InitializeComponent();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButtonToy1.Checked)
                {
                    frmGame.myPet.Buy(toy1);
                }
                else if (radioButtonToy2.Checked)
                {
                    frmGame.myPet.Buy(toy2);
                }
                else if (radioButtonToy3.Checked)
                {
                    frmGame.myPet.Buy(toy3);
                }
                MessageBox.Show("New Toys has been added");

                frmGame.labelPlayerData.Text = frmGame.myPlayer.DisplayData();

                this.Close();
                this.Owner.Close();

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void CreateToys()
        {
            toy1 = new Toy("Ball ", 300, 10, Properties.Resources.cat_toys_ball);
            listToys.Add(toy1);
            radioButtonToy1.BackgroundImage = toy1.Picture;
            labelToyData1.Text = toy1.DisplayData();

            toy2 = new Toy("Stick", 200, 5, Properties.Resources.cat_toys_stick);
            listToys.Add(toy2);
            radioButtonToy2.BackgroundImage = toy2.Picture;
            labelToyData2.Text = toy2.DisplayData();

            toy3 = new Toy("Yarn", 500, 20, Properties.Resources.cat_toys_yarn);
            listToys.Add(toy3);
            radioButtonToy3.BackgroundImage = toy3.Picture;
            labelToyData3.Text = toy3.DisplayData();



        }
        private void FormToysShop_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner.Owner;

            CreateToys();
        }
    }
}
