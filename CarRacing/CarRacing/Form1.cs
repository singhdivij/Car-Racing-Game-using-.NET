using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        int score, roadSpeed, trafficSpeed, carImage;
        int playerSpeed = 12;
        bool goleft, goright;

        Random random = new Random();
        Random carPosition = new Random();

        public Form1()
        {
            InitializeComponent();
            Reset();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            //Increase score
            distance.Text = "Score: " + score;
            score++;

            //Keep car within panel boundary.
            if (goleft == true && playerCar.Left > 10)
            {
                playerCar.Left -= playerSpeed;
            }
            if (goright == true && playerCar.Left < 290)
            {
                playerCar.Left += playerSpeed;
            }

            //Create moving road illusion.
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            //Create moving cars illusion and change them in every rotation randomly.
            aiCar1.Top += trafficSpeed;
            aiCar2.Top += trafficSpeed;

            if (aiCar1.Top > 530)
            {
                changeAIcars(aiCar1);
            }
            if (aiCar2.Top > 530)
            {
                changeAIcars(aiCar2);
            }

            //Check for collision with AI cars.
            if (playerCar.Bounds.IntersectsWith(aiCar1.Bounds) || playerCar.Bounds.IntersectsWith(aiCar2.Bounds))
            {
                gameOver();
            }

            //Increase difficulty by incrementing roadSpeed and trafficSpeed.
            if (score > 100 && score < 1000)
            {
                award.Image = Properties.Resources.bronze;
                trafficSpeed = 16;
            }
            else if (score > 1000 && score < 1500)
            {
                award.Image= Properties.Resources.silver;
                roadSpeed = 15;
                trafficSpeed = 18;
            }
            else if (score > 1500 && score < 2000)
            {
                award.Image= Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 20;
            }
            else if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                roadSpeed = 22;
                trafficSpeed = 22;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = random.Next(1, 9);

            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
                default:
                    break;

            }

            tempCar.Top = carPosition.Next(13, 403) * -1;

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 130);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(225, 305);
            }
        }

        private void gameOver()
        {
            playSound();
            explosion.Visible = true;
            gameTimer.Stop();
            playerCar.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            startButton.Enabled = true;

        }

        private void Reset()
        {
            startButton.Enabled = false;
            award.Visible = false;
            award.Image = Properties.Resources.bronze;
            explosion.Visible = false;
            goleft = false;
            goright = false;
            score = 0;

            roadSpeed = 12;
            trafficSpeed = 15;

            aiCar1.Top = carPosition.Next(13, 403) * -1;
            aiCar1.Left = carPosition.Next(5, 130);
            aiCar2.Top = carPosition.Next(13, 403) * -1;
            aiCar2.Left = carPosition.Next(225, 305);

            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            Reset();
        }
        
        private void playSound()
        {
            System.Media.SoundPlayer crashSound = new System.Media.SoundPlayer(Properties.Resources.hit);
            crashSound.Play();
        }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
