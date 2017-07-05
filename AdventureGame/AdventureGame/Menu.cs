using AdventureGame.Terrain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Menu : Form
    {


        Settings s = new Settings();
        public Menu()
        {
            InitializeComponent();
            this.button1.MouseEnter += new System.EventHandler( this.button1_MouseEnter );
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
          /*  axWindowsMediaPlayer1.URL = "D:\\Github\\AdventureGame\\AdventureGame\\AdventureGame\\Resources\\background.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();*/

           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // button1 
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ActiveCaption;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            CharSelect cs = new CharSelect();
            cs.Show();
            this.Visible = false;
        }
        

         //button2
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //button3
        private void button3_Click(object sender, EventArgs e)
        {

        }

   
        // button5
       
        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Aqua;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = SystemColors.ActiveCaption;
        }


        //mediaplayer
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        //buttom4
        private void button4_Click_1(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Aqua;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ActiveCaption;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Speicherstand beschädigt. Laden nicht möglich.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
