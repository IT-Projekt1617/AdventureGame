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
    public partial class Level_01 : Form
    {
        Player p;
        public Level_01()
        {
            InitializeComponent();
            p = new Player(player,10,20,20,0,"");
            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier2);
            
        }

        public static Label Label_1;
        public static Label Label_2;
        public static Label Label_3;
        public static Label Label_4;
        public static Label Label_5;
        public static Label Label_6;
        private void Level_01_KeyDown(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyDown(e, p);
        }

        private void Level_01_KeyUp(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyUp(e, p);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CustomEventHandler.PaintEvent(panel1,e,p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_1 = label1;
            Label_2 = label2;
            Label_3 = label3;
            Label_4 = label4;
            Label_5 = label5;
            Label_6 = label6;
            label7.Text = "Leben: "+p.getHealth()+"/"+p.getmaxHealth();
            CustomEventHandler.Update(e,p);
        }
    }
}
