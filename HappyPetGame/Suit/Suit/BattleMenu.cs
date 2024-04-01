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
    public partial class BattleMenu : Form
    {
        ChooseSuit chooseSuit;
        Random random = new Random();
        List<string> listSuitBot;
        string suitBot = "";
        public List<Suit> listSuit = new List<Suit>();
        public BattleMenu()
        {
            InitializeComponent();
        }

        private void ButtonLetsPlay_Click(object sender, EventArgs e)
        {
            ChooseSuit form = new ChooseSuit();
            form.ShowDialog();
        }

        private void BattleMenu_Load(object sender, EventArgs e)
        {
            ChooseSuit form = new ChooseSuit();
            form.Owner = this;
            chooseSuit = (ChooseSuit)this.Owner;
            listSuitBot = new List<string> { "Gunting", "Batu", "Kertas" };
            if(chooseSuit.playerSuit != null)
            {
                if (chooseSuit.playerSuit == "Gunting")
                {
                    pictureBoxPlayer.Image = Properties.Resources.gunting1;
                    pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (chooseSuit.playerSuit == "Batu")
                {
                    pictureBoxPlayer.Image = Properties.Resources.batu1;
                    pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (chooseSuit.playerSuit == "Kertas")
                {
                    pictureBoxPlayer.Image = Properties.Resources.kertas1;
                    pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void ButtonBattle_Click(object sender, EventArgs e)
        {
            int index = random.Next(listSuitBot.Count);
            if (listSuitBot[index] == "Gunting")
            {
                pictureBoxBot.Image = Properties.Resources.gunting1;
                pictureBoxBot.SizeMode = PictureBoxSizeMode.StretchImage;
                suitBot = "Gunting";
            }
            else if (listSuitBot[index] == "Batu")
            {
                pictureBoxBot.Image = Properties.Resources.batu1;
                pictureBoxBot.SizeMode = PictureBoxSizeMode.StretchImage;
                suitBot = "Batu";
            }
            else if (listSuitBot[index] == "Kertas")
            {
                pictureBoxBot.Image = Properties.Resources.kertas1;
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
            }
        }
    }
}
