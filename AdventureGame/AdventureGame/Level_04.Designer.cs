namespace AdventureGame
{
    partial class Level_04
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.door = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Slot1 = new System.Windows.Forms.PictureBox();
            this.Slot2 = new System.Windows.Forms.PictureBox();
            this.Slot3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.door);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Slot1);
            this.panel1.Controls.Add(this.Slot2);
            this.panel1.Controls.Add(this.Slot3);
            this.panel1.Controls.Add(this.player);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 261);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.door.Location = new System.Drawing.Point(46, 107);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(75, 75);
            this.door.TabIndex = 15;
            this.door.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // Slot1
            // 
            this.Slot1.BackColor = System.Drawing.Color.Transparent;
            this.Slot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slot1.Location = new System.Drawing.Point(1138, 12);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(30, 30);
            this.Slot1.TabIndex = 15;
            this.Slot1.TabStop = false;
            // 
            // Slot2
            // 
            this.Slot2.BackColor = System.Drawing.Color.Transparent;
            this.Slot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slot2.Location = new System.Drawing.Point(1178, 12);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(30, 30);
            this.Slot2.TabIndex = 14;
            this.Slot2.TabStop = false;
            // 
            // Slot3
            // 
            this.Slot3.BackColor = System.Drawing.Color.Transparent;
            this.Slot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slot3.Location = new System.Drawing.Point(1222, 12);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(30, 30);
            this.Slot3.TabIndex = 13;
            this.Slot3.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(1192, 619);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 50);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Level_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Level_04";
            this.Text = "Level_04";
            this.Load += new System.EventHandler(this.Level_04_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level_04_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level_04_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Slot1;
        private System.Windows.Forms.PictureBox Slot2;
        private System.Windows.Forms.PictureBox Slot3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}