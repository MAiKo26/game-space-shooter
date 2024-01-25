namespace space_shooter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.MoveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveForwardTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveBackTimer = new System.Windows.Forms.Timer(this.components);
            this.MyAmunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBackgroundTimer
            // 
            this.MoveBackgroundTimer.Enabled = true;
            this.MoveBackgroundTimer.Interval = 10;
            this.MoveBackgroundTimer.Tick += new System.EventHandler(this.MoveBackgroundTimer_Tick);
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(387, 600);
            this.Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(75, 77);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // MoveLeftTimer
            // 
            this.MoveLeftTimer.Interval = 5;
            this.MoveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
            // 
            // MoveForwardTimer
            // 
            this.MoveForwardTimer.Interval = 5;
            this.MoveForwardTimer.Tick += new System.EventHandler(this.MoveForwardTimer_Tick);
            // 
            // MoveRightTimer
            // 
            this.MoveRightTimer.Interval = 5;
            this.MoveRightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);
            // 
            // MoveBackTimer
            // 
            this.MoveBackTimer.Interval = 5;
            this.MoveBackTimer.Tick += new System.EventHandler(this.MoveBackTimer_Tick);
            // 
            // MyAmunitionTimer
            // 
            this.MyAmunitionTimer.Enabled = true;
            this.MyAmunitionTimer.Interval = 20;
            this.MyAmunitionTimer.Tick += new System.EventHandler(this.MyAmunitionTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 60;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(867, 683);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(889, 739);
            this.MinimumSize = new System.Drawing.Size(889, 739);
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MoveBackgroundTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MoveLeftTimer;
        private System.Windows.Forms.Timer MoveForwardTimer;
        private System.Windows.Forms.Timer MoveRightTimer;
        private System.Windows.Forms.Timer MoveBackTimer;
        private System.Windows.Forms.Timer MyAmunitionTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer EnemyMoveTimer;
    }
}

