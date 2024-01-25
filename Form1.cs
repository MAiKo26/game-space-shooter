using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace space_shooter
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;

        PictureBox[] stars;
        PictureBox[] amunitions;
        PictureBox[] enemies;

        int enemySpeed;
        int backgroundSpeed;
        int playerSpeed;
        int amunitionsSpeed;

        Random rnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundSpeed = 4;
            stars = new PictureBox[10];

            playerSpeed = 2;
            enemySpeed = 3;

            rnd = new Random();

            amunitions = new PictureBox[4];
            amunitionsSpeed = 1;
            Image amunition = Image.FromFile(@"assets\munition.png");

            Image enemy1 = Image.FromFile(@"assets\E1.png");
            Image enemy2 = Image.FromFile(@"assets\E2.png");
            Image enemy3 = Image.FromFile(@"assets\E3.png");
            Image boss1 = Image.FromFile(@"assets\Boss1.png");
            Image boss2 = Image.FromFile(@"assets\Boss2.png");

            enemies = new PictureBox[10];

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].Image = enemy1;
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enemy2;
            enemies[2].Image = enemy1;
            enemies[3].Image = enemy3;
            enemies[4].Image = boss2;
            enemies[5].Image = enemy3;
            enemies[6].Image = enemy1;
            enemies[7].Image = boss2;
            enemies[8].Image = enemy3;
            enemies[9].Image = enemy2;

            for (int i = 0; i < amunitions.Length; i++)
            {
                amunitions[i] = new PictureBox();
                amunitions[i].Size = new Size(9, 9);
                amunitions[i].Image = amunition;
                amunitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                amunitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(amunitions[i]);
            }

            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            shootMedia.URL = @"songs\shoot.mp3";
            gameMedia.URL = @"songs\GameSong.mp3";

            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootMedia.settings.volume = 1;

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
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

            gameMedia.controls.play();
        }

        private void MoveBackgroundTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundSpeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;

                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundSpeed - 2;
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
            if (e.KeyCode == Keys.Left)
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
                    //shootMedia.controls.play();

                }
                else
                {
                    shootMedia.controls.play();

                    amunitions[i].Visible = false;
                    amunitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void EnemyMoveTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies,enemySpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
    }
}
