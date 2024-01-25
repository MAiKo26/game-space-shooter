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
        WindowsMediaPlayer explosion;

        PictureBox[] stars;
        PictureBox[] amunitions;
        PictureBox[] enemies;
        PictureBox[] enemyAmunitions;

        int enemyAmunitionSpeed;
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

            rnd = new Random();

            backgroundSpeed = 4;
            playerSpeed = 2;
            enemySpeed = 3;
            enemyAmunitionSpeed = 5;
            amunitionsSpeed = 6;

            stars = new PictureBox[10];
            amunitions = new PictureBox[4];
            enemies = new PictureBox[10];
            enemyAmunitions = new PictureBox[10];

            Image amunition = Image.FromFile(@"assets\munition.png");
            Image enemy1 = Image.FromFile(@"assets\E1.png");
            Image enemy2 = Image.FromFile(@"assets\E2.png");
            Image enemy3 = Image.FromFile(@"assets\E3.png");
            Image boss1 = Image.FromFile(@"assets\Boss1.png");
            Image boss2 = Image.FromFile(@"assets\Boss2.png");


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

            for (int i = 0; i < enemyAmunitions.Length; i++)
            {
                enemyAmunitions[i] = new PictureBox();
                enemyAmunitions[i].Size = new Size(2, 25);
                enemyAmunitions[i].Visible = false;
                enemyAmunitions[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemyAmunitions[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemyAmunitions[i]);
            }

            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            shootMedia.URL = @"songs\shoot.mp3";
            gameMedia.URL = @"songs\GameSong.mp3";
            explosion.URL = @"songs\boom.mp3";

            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootMedia.settings.volume = 1;
            explosion.settings.volume = 3;

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
                    Collision();
                    CollisionWithAmunition();

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

        private void Collision()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
                if ((amunitions[0].Bounds.IntersectsWith(enemies[i].Bounds)) || (amunitions[1].Bounds.IntersectsWith(enemies[i].Bounds)) || (amunitions[2].Bounds.IntersectsWith(enemies[i].Bounds))){
                    explosion.controls.play();
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                { 
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("");
                }
        }
    }
        private void GameOver(String str)
        {
            gameMedia.controls.stop();
            StopTimers();

        }


        private void StopTimers()
        {
            
            MoveBackgroundTimer.Stop();
            MyAmunitionTimer.Stop();
            EnemyMoveTimer.Stop();
            EnemyAmunitionTimer.Stop();
        }

        private void StartTimers()
        {
            EnemyAmunitionTimer.Start();
            MoveBackgroundTimer.Start();
            MyAmunitionTimer.Start();
            EnemyMoveTimer.Start();
        }

        private void EnemyAmunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyAmunitions.Length; i++)
            {
                if (enemyAmunitions[i].Top < this.Height)
                {
                    enemyAmunitions[i].Visible = true;
                    enemyAmunitions[i].Top += enemyAmunitionSpeed;
                }
                else
                {
                    enemyAmunitions[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemyAmunitions[i].Location = new Point(enemies[x].Location.X +20 , enemies[x].Location.Y + 30);
                }
            }

        }

        private void CollisionWithAmunition()
        {
            for (int i = 0; i < enemyAmunitions.Length; i++)
            {
                if (enemyAmunitions[i].Bounds.IntersectsWith(Player.Bounds)) { 
                    
                    enemyAmunitions[i].Visible = false;
                    explosion.settings.volume = 30; // Change the volum
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("gg Game Over");
                
                }
            }
        }
    }

}
