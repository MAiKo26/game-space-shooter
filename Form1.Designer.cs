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
            this.EnemyAmunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LabelMain = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
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
            this.Player.Location = new System.Drawing.Point(258, 390);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
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
            this.MyAmunitionTimer.Interval = 10;
            this.MyAmunitionTimer.Tick += new System.EventHandler(this.MyAmunitionTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 60;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick);
            // 
            // EnemyAmunitionTimer
            // 
            this.EnemyAmunitionTimer.Enabled = true;
            this.EnemyAmunitionTimer.Interval = 40;
            this.EnemyAmunitionTimer.Tick += new System.EventHandler(this.EnemyAmunitionTimer_Tick);
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.Location = new System.Drawing.Point(179, 166);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(201, 73);
            this.ReplayBtn.TabIndex = 1;
            this.ReplayBtn.Text = "Replay";
            this.ReplayBtn.UseVisualStyleBackColor = true;
            this.ReplayBtn.Visible = false;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(179, 245);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(201, 73);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMain.ForeColor = System.Drawing.Color.Snow;
            this.LabelMain.Location = new System.Drawing.Point(151, 94);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(270, 48);
            this.LabelMain.TabIndex = 3;
            this.LabelMain.Text = "Space Shooter";
            this.LabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMain.Visible = false;
            this.LabelMain.Click += new System.EventHandler(this.LabelMain_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel.Location = new System.Drawing.Point(520, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(50, 19);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "label1";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LevelLabel.Location = new System.Drawing.Point(12, 9);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(50, 19);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(582, 455);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(598, 494);
            this.MinimumSize = new System.Drawing.Size(598, 494);
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Timer EnemyAmunitionTimer;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label LevelLabel;
    }
}

