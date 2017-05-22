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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barrier1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.barrier2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.barrier2);
            this.panel1.Controls.Add(this.barrier1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1746, 942);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barrier1
            // 
            this.barrier1.BackColor = System.Drawing.Color.Aqua;
            this.barrier1.Location = new System.Drawing.Point(561, 305);
            this.barrier1.Name = "barrier1";
            this.barrier1.Size = new System.Drawing.Size(404, 236);
            this.barrier1.TabIndex = 1;
            this.barrier1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(325, 656);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // barrier2
            // 
            this.barrier2.BackColor = System.Drawing.Color.Aqua;
            this.barrier2.Location = new System.Drawing.Point(912, 532);
            this.barrier2.Name = "barrier2";
            this.barrier2.Size = new System.Drawing.Size(404, 236);
            this.barrier2.TabIndex = 2;
            this.barrier2.TabStop = false;
            // 
            // Level_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 942);
            this.Controls.Add(this.panel1);
            this.Name = "Level_01";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level_01_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level_01_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox barrier1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox barrier2;
    }
}