﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        public Form1()
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

            Level_01 l = new Level_01();
            l.Show();
        }
        

         //button2
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //button3
        private void button3_Click(object sender, EventArgs e)
        {

        }


        //button4
        private void button4_Click(object sender, EventArgs e)
        {

        }

     
        // button5
       
        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
