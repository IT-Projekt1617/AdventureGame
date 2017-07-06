namespace AdventureGame
{
    partial class Level_01
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.barrier4 = new System.Windows.Forms.PictureBox();
            this.barrier3 = new System.Windows.Forms.PictureBox();
            this.ghost1 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.Slot1 = new System.Windows.Forms.PictureBox();
            this.Slot2 = new System.Windows.Forms.PictureBox();
            this.Slot3 = new System.Windows.Forms.PictureBox();
            this.barrier2 = new System.Windows.Forms.PictureBox();
            this.barrier1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(186)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.barrier4);
            this.panel1.Controls.Add(this.barrier3);
            this.panel1.Controls.Add(this.ghost1);
            this.panel1.Controls.Add(this.door);
            this.panel1.Controls.Add(this.enemy1);
            this.panel1.Controls.Add(this.Slot1);
            this.panel1.Controls.Add(this.Slot2);
            this.panel1.Controls.Add(this.Slot3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.barrier2);
            this.panel1.Controls.Add(this.barrier1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 681);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // barrier4
            // 
            this.barrier4.BackColor = System.Drawing.Color.Transparent;
            this.barrier4.BackgroundImage = global::AdventureGame.Properties.Resources.two_trees;
            this.barrier4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.barrier4.Location = new System.Drawing.Point(863, 149);
            this.barrier4.Name = "barrier4";
            this.barrier4.Size = new System.Drawing.Size(128, 147);
            this.barrier4.TabIndex = 17;
            this.barrier4.TabStop = false;
            // 
            // barrier3
            // 
            this.barrier3.BackColor = System.Drawing.Color.Transparent;
            this.barrier3.BackgroundImage = global::AdventureGame.Properties.Resources.tree_stump;
            this.barrier3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.barrier3.Location = new System.Drawing.Point(284, 185);
            this.barrier3.Name = "barrier3";
            this.barrier3.Size = new System.Drawing.Size(128, 79);
            this.barrier3.TabIndex = 16;
            this.barrier3.TabStop = false;
            // 
            // ghost1
            // 
            this.ghost1.BackColor = System.Drawing.Color.Transparent;
            this.ghost1.BackgroundImage = global::AdventureGame.Properties.Resources.ghost;
            this.ghost1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ghost1.Location = new System.Drawing.Point(916, 619);
            this.ghost1.Name = "ghost1";
            this.ghost1.Size = new System.Drawing.Size(60, 50);
            this.ghost1.TabIndex = 15;
            this.ghost1.TabStop = false;
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImage = global::AdventureGame.Properties.Resources.opendoor;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.door.Location = new System.Drawing.Point(1177, 594);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(75, 75);
            this.door.TabIndex = 14;
            this.door.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImage = global::AdventureGame.Properties.Resources.zombie;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemy1.Location = new System.Drawing.Point(1080, 185);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(60, 50);
            this.enemy1.TabIndex = 13;
            this.enemy1.TabStop = false;
            this.enemy1.Click += new System.EventHandler(this.enemy1_Click);
            // 
            // Slot1
            // 
            this.Slot1.BackColor = System.Drawing.Color.Transparent;
            this.Slot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slot1.Location = new System.Drawing.Point(1138, 12);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(30, 30);
            this.Slot1.TabIndex = 12;
            this.Slot1.TabStop = false;
            this.Slot1.Click += new System.EventHandler(this.Slot1_Click);
            // 
            // Slot2
            // 
            this.Slot2.BackColor = System.Drawing.Color.Transparent;
            this.Slot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slot2.Location = new System.Drawing.Point(1178, 12);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(30, 30);
            this.Slot2.TabIndex = 11;
            this.Slot2.TabStop = false;
            this.Slot2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Slot3
            // 
            this.Slot3.BackColor = System.Drawing.Color.Transparent;
            this.Slot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slot3.Location = new System.Drawing.Point(1222, 12);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(30, 30);
            this.Slot3.TabIndex = 10;
            this.Slot3.TabStop = false;
            this.Slot3.Click += new System.EventHandler(this.Slot3_Click);
            // 
            // barrier2
            // 
            this.barrier2.BackColor = System.Drawing.Color.Transparent;
            this.barrier2.BackgroundImage = global::AdventureGame.Properties.Resources.rock;
            this.barrier2.Location = new System.Drawing.Point(263, 436);
            this.barrier2.Name = "barrier2";
            this.barrier2.Size = new System.Drawing.Size(128, 132);
            this.barrier2.TabIndex = 7;
            this.barrier2.TabStop = false;
            this.barrier2.Click += new System.EventHandler(this.barrier2_Click);
            // 
            // barrier1
            // 
            this.barrier1.BackColor = System.Drawing.Color.Transparent;
            this.barrier1.BackgroundImage = global::AdventureGame.Properties.Resources.tree;
            this.barrier1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.barrier1.Location = new System.Drawing.Point(530, 281);
            this.barrier1.Name = "barrier1";
            this.barrier1.Size = new System.Drawing.Size(128, 147);
            this.barrier1.TabIndex = 1;
            this.barrier1.TabStop = false;
            this.barrier1.Click += new System.EventHandler(this.barrier1_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(12, 619);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // Level_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Level_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            this.Load += new System.EventHandler(this.Level_01_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level_01_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level_01_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox barrier1;
        private System.Windows.Forms.PictureBox barrier2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox Slot1;
        private System.Windows.Forms.PictureBox Slot2;
        private System.Windows.Forms.PictureBox Slot3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox ghost1;
        private System.Windows.Forms.PictureBox barrier3;
        private System.Windows.Forms.PictureBox barrier4;
    }
}