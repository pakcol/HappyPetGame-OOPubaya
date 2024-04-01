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
    public partial class FormSelectMinigames : Form
    {
        FormGame frmGame;
        public FormSelectMinigames()
        {
            InitializeComponent();
        }

        private void pictureBoxSnake_Click(object sender, EventArgs e)
        {

        }

        private void buttonSuit_Click(object sender, EventArgs e)
        {
            FormChooseSuit frmSuit = new FormChooseSuit();
            frmSuit.Owner = this;
            frmSuit.ShowDialog();
        }

        private void FormSelectMinigames_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmGame.timerGame.Enabled = true;
        }

        private void FormSelectMinigames_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
        }

        private void buttonSnake_Click(object sender, EventArgs e)
        {
            FormSnakeGame frmSnake = new FormSnakeGame();
            frmSnake.Owner = this;
            frmSnake.ShowDialog();
        }
    }
}
