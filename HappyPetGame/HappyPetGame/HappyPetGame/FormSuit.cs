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
    public partial class FormSuit : Form
    {
        FormChooseSuit chooseSuit;
        Random random = new Random();
        List<string> listSuitBot;
        string suitBot = "";
        public List<Suit> listSuit = new List<Suit>();
        public FormSuit()
        {
            InitializeComponent();
        }

        private void FormSuit_Load(object sender, EventArgs e)
        {
            
            chooseSuit = (FormChooseSuit)this.Owner;
            listSuitBot = new List<string> { "Gunting", "Batu", "Kertas" };

            if (chooseSuit.playerSuit != null)
            {
                if (chooseSuit.playerSuit == "Gunting")
                {
                    pictureBoxPlayer.Image = Properties.Resources.gunting;
                    pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (chooseSuit.playerSuit == "Batu")
                {
                    pictureBoxPlayer.Image = Properties.Resources.batu;
                    pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (chooseSuit.playerSuit == "Kertas")
                {
                    pictureBoxPlayer.Image = Properties.Resources.kertas;
                    pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void buttonBattle_Click(object sender, EventArgs e)
        {
            int index = random.Next(listSuitBot.Count);
            if (listSuitBot[index] == "Gunting")
            {
                pictureBoxBot.Image = Properties.Resources.gunting;
                pictureBoxBot.SizeMode = PictureBoxSizeMode.StretchImage;
                suitBot = "Gunting";
            }
            else if (listSuitBot[index] == "Batu")
            {
                pictureBoxBot.Image = Properties.Resources.batu;
                pictureBoxBot.SizeMode = PictureBoxSizeMode.StretchImage;
                suitBot = "Batu";
            }
            else if (listSuitBot[index] == "Kertas")
            {
                pictureBoxBot.Image = Properties.Resources.kertas;
                pictureBoxBot.SizeMode = PictureBoxSizeMode.StretchImage;
                suitBot = "Kertas";
            }
            if (chooseSuit.playerSuit != "")
            {
                if (chooseSuit.playerSuit == "Gunting" && suitBot == "Kertas" ||
               chooseSuit.playerSuit == "Batu" && suitBot == "Gunting" ||
               chooseSuit.playerSuit == "Kertas" && suitBot == "Batu")
                {
                    MessageBox.Show("Anda Menang!");
                }
                else if (chooseSuit.playerSuit == "Batu" && suitBot == "Kertas" ||
                        chooseSuit.playerSuit == "Kertas" && suitBot == "Gunting" ||
                        chooseSuit.playerSuit == "Gunting" && suitBot == "Batu")
                {
                    MessageBox.Show("Anda Kalah!");
                }
                else if (chooseSuit.playerSuit == "Batu" && suitBot == "Batu" ||
                        chooseSuit.playerSuit == "Kertas" && suitBot == "Kertas" ||
                        chooseSuit.playerSuit == "Gunting" && suitBot == "Gunting")
                {
                    MessageBox.Show("Anda Seri!");
                }
            }

        }
    }
}
