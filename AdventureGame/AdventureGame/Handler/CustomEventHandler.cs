using AdventureGame.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    class CustomEventHandler
    {


        public static void KeyDown(KeyEventArgs e,Player p)
        {

            if (e.KeyCode == Keys.W)
            {
                p.setUp(true);
            }

            if (e.KeyCode == Keys.S)
            {
                p.setDown(true);
            }

            if (e.KeyCode == Keys.A)
            {
                p.setLeft(true);
            }

            if (e.KeyCode == Keys.D)
            {
                p.setRight(true);
            }

        }
        public static void KeyUp(KeyEventArgs e, Player p)
        {

            if (e.KeyCode == Keys.W)
            {
                p.setUp(false);
            }

            if (e.KeyCode == Keys.S)
            {
                p.setDown(false);
            }

            if (e.KeyCode == Keys.A)
            {
                p.setLeft(false);
            }

            if (e.KeyCode == Keys.D)
            {
                p.setRight(false);
            }

        }
        public static void Update(EventArgs e,Player player)
        {

            /*
            if (oben)
            {
                Level_01.Label_1.Text = "True";
            }
            else
            {
                Level_01.Label_1.Text = "False";
            }
            if (unten)
            {
                Level_01.Label_2.Text = "True";
            }
            else
            {
                Level_01.Label_2.Text = "False";
            }
            if (rechts)
            {
                Level_01.Label_3.Text = "True";
            }
            else
            {
                Level_01.Label_3.Text = "False";
            }
            if (links)
            {
                Level_01.Label_4.Text = "True";
            }
            else
            {
                Level_01.Label_4.Text = "False";
            }
            if (btou)
            {
                Level_01.Label_5.Text = "True";
            }
            else
            {
                Level_01.Label_5.Text = "False";
            }
            if (btrl)
            {
                Level_01.Label_6.Text = "True";
            }
            else
            {
                Level_01.Label_6.Text = "False";
            }*/

            foreach (LivingEntity le in LivingEntityHandler.getLivingEntitys())
            {
                PictureBox p = le.getEntity();
                int speed = le.getSpeed();

                if (le.getUp() && !le.getCollideUp())
                {
                    p.Top -= speed;
                }
                else
                {
                    le.setUp(false);
                }
                if (le.getDown() && !le.getCollideDown())
                {
                    p.Top += speed;
                }
                else
                {
                    le.setDown(false);
                }
                if (le.getRight() && !le.getCollideRight())
                {
                    p.Left += speed;
                }
                else
                {
                    le.setRight(false);
                }
                if (le.getLeft() && !le.getCollideLeft())
                {
                    p.Left -= speed;
                }
                else
                {
                    le.setLeft(false);
                }
            }
            
        }

        public static void PaintEvent(Panel panel, PaintEventArgs e,Player player)
        {
            CollisionHandler.calculateCollisions(panel,player,Barrier.getBarrierList());

        }


    }
}
