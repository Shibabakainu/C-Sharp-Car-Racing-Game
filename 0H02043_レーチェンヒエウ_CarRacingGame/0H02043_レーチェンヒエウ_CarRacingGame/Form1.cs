using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0H02043_レーチェンヒエウ_CarRacingGame
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random r = new Random();
        Random carPosition = new Random();

        bool goleft, goright;
        public Form1()
        {
            InitializeComponent();
            ResetGame();
            
        }

        private void GameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            score++;

            if(goleft == true && Player.Left > 5)
            {
                Player.Left -= playerSpeed;
            }
            if(goright == true && Player.Left < 420)
            {
                Player.Left += playerSpeed;
            }

            Road1.Top += roadSpeed;
            Road2.Top += roadSpeed;

            if (Road1.Top > 514)
            {
                Road1.Top = -514;
            }
            if (Road2.Top > 514)
            {
                Road2.Top = -514;
            }

            Car1.Top += trafficSpeed;
            Car2.Top += trafficSpeed;

            if (Car1.Top > 530)
            {
                changeCars(Car1);
            }
            if (Car2.Top > 530)
            {
                changeCars(Car2);
            }

            if (Player.Bounds.IntersectsWith(Car1.Bounds) || Player.Bounds.IntersectsWith(Car2.Bounds))
            {
                gameOver();
            }

            if (score > 150 && score < 300)
            {
                txtLevel.Text = "Level: 2";
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (score > 300 && score < 400)
            {
                txtLevel.Text = "Level: 3";
                trafficSpeed = 27;
                roadSpeed = 25;
            }
            if (score > 400 && score < 500)
            {
                txtLevel.Text = "Level: 4";
                trafficSpeed = 35;
                roadSpeed = 28;
            }
            if (score > 500)
            {
                txtLevel.Text = "Level: 5";
                trafficSpeed = 45;
                roadSpeed = 35;
            }
        }

        private void PressUp(object sender, KeyEventArgs e)
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

        private void PressDown(object sender, KeyEventArgs e)
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

        private void changeCars(PictureBox tempCar)
        {
            carImage = r.Next(1,9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(250, 430);
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            picGameOver.Visible = true;
            StartButton.Enabled = true;
        }

        private void ResetGame()
        {
            StartButton.Enabled = false;
            picGameOver.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            txtLevel.Text = "Level: 1";

            roadSpeed = 12;
            trafficSpeed = 15;

            Car1.Top = carPosition.Next(200, 500) * -1;
            Car1.Left = carPosition.Next(5, 200);

            Car2.Top = carPosition.Next(200, 500) * -1;
            Car2.Left = carPosition.Next(250, 430);

            timer1.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

    }
}
