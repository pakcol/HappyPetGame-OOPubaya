using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame
{
    public partial class FormGame : Form
    {
        public Player myPlayer;

        //polymorphism : declare sebagai parentnya
        public Pet myPet;

        public BindingList<Player> listPlayer = new BindingList<Player>();
        public List<Pet> listPet = new List<Pet>();

        int detik;
        public FormGame()
        {
            InitializeComponent();
        }

        public void StartGame()
        {
            //tampilkan data player dan pet di label yang ada di form game
            labelPlayerData.Text = myPlayer.DisplayData();
            labelPetData.Text = myPet.DisplayData();
            labelDate.Text = DateTime.Now.ToString();


            //aktifkan panel data dan activity
            panelData.Visible = true;
            panelActivity.Visible = true;
            buttonMinigames.Visible = true;

            //tampilkan gambar petnya
            pictureBoxPet.Visible = true;
            pictureBoxPet.Image = myPet.Picture;
            pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;

            if (myPet is Cat)
            {
                buttonPlay.Enabled = true;
                buttonBath.Enabled = true;
                buttonVaccine.Enabled = true;
                buttonClean.Enabled = false;
            }
            else if (myPet is Fish)
            {
                buttonPlay.Enabled = false;
                buttonBath.Enabled = false;
                buttonVaccine.Enabled = false;
                buttonClean.Enabled = true;
            }
            else if (myPet is Chameleon)
            {
                
                buttonPlay.Enabled = false;
                buttonBath.Enabled = false;
                buttonVaccine.Enabled = false;
                buttonClean.Enabled = false;
            }

            timerGame.Interval = 1000;
            timerGame.Start();
        }
        private void ChangeImageActivity(string activity)
        {
            if(myPet is Cat)
            {
                if(activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_feed;
                }
                else if (activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_sleep;
                }
                else if (activity == "Bath")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_shower;
                }
                else if (activity == "Vaccinate")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_vaccinate;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_happy;
                }
            }
            else if (myPet is Fish)
            {
                if (activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_feed;
                }
                else if (activity == "Clean")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_clean;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_happy;
                }
            }
            else if (myPet is Chameleon)
            {
                if (activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_feed;
                }
                else  if (activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_leaves;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_happy;
                }
            }
            detik = 0;
            timerActivity.Interval = 1000;
            timerActivity.Start();
        }
       

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Properties.Resources.Room;
            //this.BackgroundImageLayout = ImageLayout.Stretch;\
            panelData.Visible = false;
            panelActivity.Visible = false;
            buttonMinigames.Visible = false;

            //baca data dari file
            ReadDataPet("petData.gm");
            ReadDataPlayer("playerData.gm");
            


        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = false;
            FormSelectToys frmSelectToys = new FormSelectToys();
            frmSelectToys.Owner = this;
            frmSelectToys.ShowDialog();
            
            //pakai downcasting buat panggil method yang ada di 1 child aja

        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer frmSelectPlayer = new FormSelectPlayer();
            frmSelectPlayer.Owner = this;
            frmSelectPlayer.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            myPet.Feed();

            labelPetData.Text = myPet.DisplayData();

            ChangeImageActivity("Feed");
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            myPet.Sleep();

            labelPetData.Text = myPet.DisplayData();

            ChangeImageActivity("Sleep");
        }

        private void buttonVaccine_Click(object sender, EventArgs e)
        {
            try
            {
                if (myPet is Cat)
                {
                    ((Cat)myPet).Vaccinate();

                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();

                    ChangeImageActivity("Vaccinate");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            if(myPet is Fish)
            {
                ((Fish)myPet).Clean();

                labelPetData.Text = myPet.DisplayData();
                labelPlayerData.Text = myPlayer.DisplayData();

                ChangeImageActivity("Clean");
            }
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            if(myPet is Cat)
            {
                ((Cat)myPet).Bath();

                labelPetData.Text = myPet.DisplayData();

                ChangeImageActivity("Bath");
            }
        }

        private void timerActivity_Tick(object sender, EventArgs e)
        {
            detik++;

            if(detik == 3)
            {
                timerActivity.Stop();
                ChangeImageActivity("-");

            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            myPet.Health -= 5;
            myPet.Energy -= 5;
            myPet.Happiness -= 5;

            labelPetData.Text = myPet.DisplayData();
            labelPlayerData.Text = myPlayer.DisplayData();

            if(myPet.CheckHealth() == "Very Poor" && 
               myPet.CheckEnergy() == "Weak" &&
               myPet.CheckHappiness() == "Unhappy")
            {
                timerGame.Stop();
                MessageBox.Show("GAME OVER \nYour pet is ded");
                panelData.Visible = false;
                panelActivity.Visible = false;
                pictureBoxPet.Visible = false;
            }
        }
        private void SaveDataPlayer(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listPlayer);
            myFile.Close();
        }
        private void ReadDataPlayer(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listPlayer = (BindingList<Player>)formatter.Deserialize(myFile);
                myFile.Close();
            }

        }
        private void SaveDataPet(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listPet);
            myFile.Close();
        }
        private void ReadDataPet(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listPet = (List<Pet>)formatter.Deserialize(myFile);
                myFile.Close();
            }
        }
        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataPet("petData.gm");
            SaveDataPlayer("playerData.gm");
            
        }

        private void changePetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePet frmChangePet = new FormChangePet();
            frmChangePet.Owner = this;
            frmChangePet.ShowDialog();
        }

        private void resatGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetPet();
            resetPlayer();
        }

        private void resetPet()
        {
            
            if (myPet is Cat)
            {
                myPet = new Cat(myPet.Name, pictureBoxPet.Image,
                                        myPlayer, false);
            }
            else if (myPet is Fish)
            {
                
                myPet = new Fish(myPet.Name, pictureBoxPet.Image,
                                        myPlayer, myPet.myEnvironment());
            }
            else if (myPet is Chameleon)
            {
                myPet = new Chameleon(myPet.Name,
                                              pictureBoxPet.Image,
                                              myPlayer, Color.Green);
            }
            
        }

        private void resetPlayer()
        {
            myPlayer = new Player(myPlayer.Name, 100, DateTime.Now);
        }

        private void buttonMinigames_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = false;
            FormSelectMinigames frmSelectMinigames = new FormSelectMinigames();
            frmSelectMinigames.Owner = this;
            frmSelectMinigames.ShowDialog();
        }

    }
}
