using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace space_shooter
{
    public partial class Form1 : Form { 

        PictureBox[] stars;
        PictureBox[] amunitions;

        int backgroundspeed;
        int playerSpeed;
        int amunitionsSpeed;

        Random rnd;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 4;
            stars = new PictureBox[10];

            playerSpeed = 2;

            rnd = new Random();

            amunitions = new PictureBox[4];
            amunitionsSpeed = 1;
            Image amunition = Image.FromFile(@"assets\munition.png");


            for (int i = 0; i < amunitions.Length; i++)
            {
                amunitions[i] = new PictureBox();
                amunitions[i].Size = new Size(9, 9);
                amunitions[i].Image = amunition;
                amunitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                amunitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(amunitions[i]);
            }

            for (int i = 0; i<stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20,580), rnd.Next(-10,400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }
        }

        private void MoveBackgroundTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length/2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;

                }
            }
            for (int i = stars.Length / 2; i < stars.Length ; i++)
            {
                stars[i].Top += backgroundspeed-2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;

                }
            }
        }

        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void MoveForwardTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerSpeed;
            }
        }

        private void MoveBackTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top += playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                MoveLeftTimer.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRightTimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveForwardTimer.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveBackTimer.Start();
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MoveRightTimer.Stop();
            MoveLeftTimer.Stop();
            MoveForwardTimer.Stop();
            MoveBackTimer.Stop();

        }

        private void MyAmunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < amunitions.Length; i++)
            {
                if (amunitions[i].Top > 0)
                {
                    amunitions[i].Visible = true;
                    amunitions[i].Top -= amunitionsSpeed;
                }
                else
                {
                    amunitions[i].Visible = false;
                    amunitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

      
    }
}
