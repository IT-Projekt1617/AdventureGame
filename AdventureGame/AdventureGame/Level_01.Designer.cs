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
            this.ghost1 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.Slot1 = new System.Windows.Forms.PictureBox();
            this.Slot2 = new System.Windows.Forms.PictureBox();
            this.Slot3 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.barrier2 = new System.Windows.Forms.PictureBox();
            this.barrier1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
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
            // ghost1
            // 
            this.ghost1.BackColor = System.Drawing.Color.Aquamarine;
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
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.door.Location = new System.Drawing.Point(1177, 594);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(75, 75);
            this.door.TabIndex = 14;
            this.door.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.DarkRed;
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 681);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // barrier2
            // 
            this.barrier2.BackColor = System.Drawing.Color.Transparent;
            this.barrier2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barrier2.Location = new System.Drawing.Point(792, 409);
            this.barrier2.Name = "barrier2";
            this.barrier2.Size = new System.Drawing.Size(33, 236);
            this.barrier2.TabIndex = 7;
            this.barrier2.TabStop = false;
            // 
            // barrier1
            // 
            this.barrier1.BackColor = System.Drawing.Color.Transparent;
            this.barrier1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barrier1.Location = new System.Drawing.Point(421, 185);
            this.barrier1.Name = "barrier1";
            this.barrier1.Size = new System.Drawing.Size(404, 236);
            this.barrier1.TabIndex = 1;
            this.barrier1.TabStop = false;
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
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
    }
}