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
        public static void KeyUp(Panel panel, KeyEventArgs e, Player p)
        {

            CollisionHandler.calculateCollisions(panel, p, Barrier.getBarrierList());

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
        public static void Update(Panel panel,EventArgs e,Player player)
        {

            CollisionHandler.calculateCollisions(panel, player, Barrier.getBarrierList());

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
                    le.setCollideUp(false);
                }
                if (le.getDown() && !le.getCollideDown())
                {
                    p.Top += speed;
                }
                else
                {
                    le.setDown(false);
                    le.setCollideDown(false);
                }
                if (le.getRight() && !le.getCollideRight())
                {
                    p.Left += speed;
                }
                else
                {
                    le.setRight(false);
                    le.setCollideRight(false);
                }
                if (le.getLeft() && !le.getCollideLeft())
                {
                    p.Left -= speed;
                }
                else
                {
                    le.setLeft(false);
                    le.setCollideLeft(false);
                }
                
            }
            
        }

        public static void PaintEvent(Panel panel, PaintEventArgs e,Player player)
        {
            //CollisionHandler.calculateCollisions(panel,player,Barrier.getBarrierList());

        }


    }
}
