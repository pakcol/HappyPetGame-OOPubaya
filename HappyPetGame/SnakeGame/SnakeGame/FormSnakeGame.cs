using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormSnakeGame : Form
    {
        public BindingList<Circle> Snake = new BindingList<Circle>();
        private Circle food = new Circle();

        #region Variables
        //max tinggi dan lebar snake berjalan
        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand= new Random();

        //pergi kiri, kanan, atas, bawah
        bool goLeft, goRight, goUp, goDown;
        bool start;
        #endregion

        public FormSnakeGame()
        {
            InitializeComponent();

            new Settings();
        }

        private void FormSnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A)&&Settings.Directions != "Right")
            {
                goLeft = true;
            }
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Settings.Directions != "Left")
            {
                goRight = true;
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && Settings.Directions != "Down")
            {
                goUp = true;
            }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && Settings.Directions != "Up")
            {
                goDown = true;
            }
        }

        private void FormSnakeGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            RestartGame();
            start = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSnakeGame_Tick(object sender, EventArgs e)
        {
            //setting direction
            if (goLeft)
            {
                Settings.Directions = "Left";
            }
            if (goRight)
            {
                Settings.Directions = "Right";
            }
            if (goUp)
            {
                Settings.Directions = "Up";
            }
            if (goDown)
            {
                Settings.Directions = "Down";
            }
            //end setting direction

            //memastikan bagian badannya mengikuti sesuai arahnya
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //bagian kepala
                if (i == 0)
                {
                    switch (Settings.Directions) 
                    {
                        case "Left":
                            Snake[i].X--;
                            break;
                        case "Right":
                            Snake[i].X++;
                            break;
                        case "Up":
                            Snake[i].Y--;
                            break;
                        case "Down":
                            Snake[i].Y++;
                            break;
                    }

                    //kalau ke pojok bakal muncul di arah satunya
                    if (Snake[i].X < 0) Snake[i].X = maxWidth;
                    if (Snake[i].X > maxWidth) Snake[i].X = 0;
                    if (Snake[i].Y < 0) Snake[i].Y = maxHeight;
                    if (Snake[i].Y > maxHeight) Snake[i].Y = 0;

                    //ketika snake makan
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    //ketika snake makan bagian badannya
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y) GameOver();
                    }
                }
                else
                {
                    //memastikan bagian badan(slain kepala) mengikuti bagian badan sebelumnya
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            //untuk update picture box
            pictureBoxCanvas.Invalidate();
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor;

            if (start)
            {
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColor = Brushes.Black;
                    }
                    else
                    {
                        snakeColor = Brushes.DarkGreen;
                    }

                    canvas.FillEllipse(snakeColor, new Rectangle
                        (Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height));

                }
                canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                        (food.X * Settings.Width,
                        food.Y * Settings.Height,
                        Settings.Width, Settings.Height));
            }
        }

        private void RestartGame()
        {
            maxWidth = (pictureBoxCanvas.Width / Settings.Width) - 1;
            maxHeight = (pictureBoxCanvas.Height / Settings.Height) - 1;

            //Menghapus badannya snake
            Snake.Clear();

            //mengganti button Start
            buttonStart.BackColor = Color.Maroon;
            buttonStart.Enabled = false;
            buttonExit.Enabled = false;
            score = 0;
            labelScore.Text = score.ToString();

            //menambahkan kepala pada bagian tubuh snake
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            //loop untuk nambah badan
            for (int i = 0; i < 10; i++) 
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            //bikin makanan
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            timerSnakeGame.Start();
        }

        private void EatFood()
        {
            score += 1;
            labelScore.Text = score.ToString();
            Circle body = new Circle
            {
                X = Snake[Snake.Count -1].X,
                Y = Snake[Snake.Count -1].Y
            };
            Snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {
            start = false;
            timerSnakeGame.Stop();
            buttonStart.BackColor = Color.Lime;
            buttonStart.Enabled = true;
            buttonExit.Enabled = true;

            if (score > highScore)
            { 
                highScore = score;
                labelHighScore.Text = highScore.ToString();
            }

            MessageBox.Show("Game Over");
        }
    }
}
