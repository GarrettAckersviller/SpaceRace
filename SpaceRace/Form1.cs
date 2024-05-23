

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using System;

using System.Windows.Forms;

using System.Media;

namespace SpaceRace


{
    public partial class Form1 : Form
    {
        Rectangle p1 = new Rectangle(125, 350, 12, 28);
        Rectangle p2 = new Rectangle(450, 350, 12, 28);
        int playerSpeed = 3;

        int ballSpeed = 8;

        List<Rectangle> ballList = new List<Rectangle>();
        List<int> ballSpeeds = new List<int>();
        List<string> direction = new List<string>();

        int time = 3600;

        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Pen black = new Pen(Color.Black);
        Rectangle border = new Rectangle(265, 100, 250, 250);

        Random randGen = new Random();
        int randValue = 0;

        int p1Score = 0;
        int p2Score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Space:
                    if (time == 3600)
                    {
                        startLabel.Text = null;
                        spaceTimer.Start();
                    }
                    else if (time == 0)
                    {
                        p1Score = 0;
                        p2Score = 0;
                        time = 3600;
                        
                        startLabel.Text = null;
                        spaceTimer.Start();
                    } 

                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, p1);
            e.Graphics.FillRectangle(whiteBrush, p2);
           
            tLabel.Text = $"Time: {time}";

            for (int i = 0; i < ballList.Count(); i++)
            {
                e.Graphics.FillRectangle(whiteBrush, ballList[i]);
            }

            sLabel.Text = $"{p1Score} - {p2Score}";
        }

        private void spaceTimer_Tick_1(object sender, EventArgs e)
        {
            keyCheck();

           
            for (int i = 0; i < ballList.Count(); i++)
            {
                int x = ballList[i].X + ballSpeeds[i];
                ballList[i] = new Rectangle(x, ballList[i].Y, 5, 5);
            }

           
            randValue = randGen.Next(0, 2);
            if (randValue == 1)
            {
                randValue = randGen.Next(0, 100);
                if (randValue < 12)
                {
                    randValue = randGen.Next(10, this.Height - 34 * 2);

                    Rectangle ball = new Rectangle(0, randValue, 5, 5);
                    ballList.Add(ball);
                    ballSpeeds.Add(randGen.Next(1, 4));
                }
            }
            else
            {
                randValue = randGen.Next(0, 100);
                if (randValue < 12)
                {
                    randValue = randGen.Next(10, this.Height - 34 * 2);

                    Rectangle ball = new Rectangle(this.Width, randValue, 5, 5);
                    ballList.Add(ball);
                    ballSpeeds.Add(randGen.Next(-4, -1));
                }
            }

            if (p1.Y < 0)
            {
                p1.Y = 350;
                p1Score++;
            }

            if (p2.Y < 0)
            {
                p2.Y = 350;
                p2Score++;
            }


            for (int i = 0; i < ballList.Count(); i++)
            {
               if (p1.IntersectsWith(ballList[i]))
                {
                    ballList.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Bomb_SoundBible_com_891110113);

                    player.Play();

                    p1.X = 125;
                    p1.Y = 350;

                }
            }

            for (int i = 0; i < ballList.Count(); i++)
            {
                if (p2.IntersectsWith(ballList[i]))
                {
                    ballList.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Bomb_SoundBible_com_891110113);

                    player.Play();

                    p2.X = 450;
                    p2.Y = 350;

                }
            }


            Refresh();




            time--;

            if (time == 0)
            {
                spaceTimer.Stop();

               
                   
                if (p1Score > p2Score)
                {
                    startLabel.Text = " Game over, Player 1 wins ";
                }

                else if (p1Score == p2Score)
                {
                    startLabel.Text = " Game Over Tie ";
                }

                else
                {
                    startLabel.Text = " Game over Player 2 wins ";
                }


            }

        }

        public void keyCheck()
        {
            if (wPressed == true)
            {
               
                p1.Y -= playerSpeed;


            }
            if (sPressed == true && p1.Y < this.Height - p1.Height)
            {
                p1.Y += playerSpeed;
            }

            if (upPressed == true)
            {
                p2.Y -= playerSpeed;
            }
            if (downPressed == true && p2.Y < this.Height - p2.Height)
            {
                p2.Y += playerSpeed;
                
            }

        }
    }
}

