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

            p = new Player(player, 10, 20, 20, 0, null);
            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier2);

            
            
        }
        private void Level_01_KeyDown(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyDown(e, p);
        }

        private void Level_01_KeyUp(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyUp(panel1,e, p);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CustomEventHandler.PaintEvent(panel1,e,p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = "Leben: "+p.getHealth()+"/"+p.getmaxHealth();
            CustomEventHandler.Update(panel1,e,p);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void Level_01_Load(object sender, EventArgs e)
        {

            if (CharSelect.Char == 2)
            {
                p.setTexturepath(Properties.Resources.Ch_cho_img_03);
            }
            else if (CharSelect.Char == 1)
            {
                p.setTexturepath(Properties.Resources.Ch_van_img_03);

            }
        }
    }
}
