using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Making_Game_inForm_
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, jumping, isGameOver;

        int jumpspeed;
        int force;
        int playerspeed = 7;

        int enemyOneSpeed = 7;
        int enemyTwoSpeed = 4;

        int horizontalspeed = 3;
        int verticalspeed = 3;
        int verticalspeed2 = 2;




        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Player.Top += jumpspeed;

            if(goLeft == true)
            {
                Player.Left -= playerspeed;
            }
            if(goRight == true)
            {
                Player.Left += playerspeed;
            }

            if(jumping == true && force < 0)
            {
                jumping = false;
            }

            if(jumping == true)
            {
                jumpspeed = -8;
                force -= 1;
            }

            else
            {
                jumpspeed = 10;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {

                    if((string)x.Tag == "Platform")
                    {
                        if(Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            Player.Top = x.Top - Player.Height;

                            if((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                Player.Left -= horizontalspeed;
                            }
                        }

                        x.BringToFront();
                    }
                    else if ((string)x.Tag == "nonPlatform")
                    {
                        if(Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            Player.Left = x.Left - Player.Width;
                        }

                    }
                    else if ((string)x.Tag == "nonPlatform2")
                    {

                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            Player.Left = x.Left + Player.Width;
                        }


                    }

                    if((string)x.Tag == "enemy")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameTimer.Stop();
                            isGameOver = true;
                            label1.Text = Environment.NewLine + "You were killed by enemy!!!  Press 'enter' to restart.";

                        }
                    }

                    if((string)x.Tag == "thorn")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameTimer.Stop();
                            isGameOver = true;
                            label1.Text = Environment.NewLine + "You stepped the thorns!!!  Press 'enter' to restart.";
                        }
                    }
                }
            }

            horizontalPlatform.Left -= horizontalspeed;
            if(horizontalPlatform.Left <0  || horizontalPlatform.Left >260/*horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width*/)
            {
                horizontalspeed = -horizontalspeed;
            }

            verticalPlatform.Top += verticalspeed;
            if(verticalPlatform.Top < 318 || verticalPlatform.Top > 450)
            {
                verticalspeed = -verticalspeed;
            }

            verticalPlatform2.Top += verticalspeed2;
            if(verticalPlatform2.Top < 9 || verticalPlatform2.Top > 109)
            {
                verticalspeed2 = -verticalspeed2;
            }

            enemyOne.Left -= enemyOneSpeed;
            if(enemyOne.Left <= pictureBox5.Left || enemyOne.Left + enemyOne.Width >= pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemyTwo.Left -= enemyTwoSpeed;
            if (enemyTwo.Left <= pictureBox4.Left || enemyTwo.Left + enemyTwo.Width >= pictureBox4.Left + pictureBox4.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            if(Player.Top + Player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                isGameOver = true;
                label1.Text = Environment.NewLine + "You fell out of the world! Press 'enter' to restart.";
            }


            if(Player.Bounds.IntersectsWith(Gold.Bounds))
            {
                GameTimer.Stop();
                isGameOver = true;
                label1.Text = Environment.NewLine + "You reached the gold in safe!    WELL DONE!!!";
            }

        }


        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What are you doing?!? Just use your arrow keys to move and press space for jump.","Don't you know how to play a platform game?",MessageBoxButtons.OK);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(jumping == true)
            {
                jumping = false;
            }

            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }

        }

        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;

            label1.Text = "";


            Player.Left = 25;
            Player.Top = 482;

            enemyOne.Left = 776;
            enemyTwo.Left = 252;

            horizontalPlatform.Left = 250;
            verticalPlatform.Top = 420;
            verticalPlatform2.Top = 89;

            GameTimer.Start();

        }

        
    }
}
