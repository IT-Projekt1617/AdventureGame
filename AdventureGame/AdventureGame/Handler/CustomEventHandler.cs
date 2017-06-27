using AdventureGame.Enity;
using AdventureGame.Handler;
using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    class CustomEventHandler
    {


        public static void KeyDown(KeyEventArgs e,Player p,Control c)
        {

            if (e.KeyCode == Keys.W)
            {
                p.setUp(true);
                AnimationHandler.setLocationType(Location.TOP);
            }

            if (e.KeyCode == Keys.S)
            {
                p.setDown(true);
                AnimationHandler.setLocationType(Location.BOT);
            }

            if (e.KeyCode == Keys.A)
            {
                p.setLeft(true);
                AnimationHandler.setLocationType(Location.LEFT);
            }

            if (e.KeyCode == Keys.D)
            {
                p.setRight(true);
                AnimationHandler.setLocationType(Location.RIGHT);

            }

            if (e.KeyCode == Keys.Q)
            {
                p.dropItem(c);
            }

            if (e.KeyCode == Keys.Space)
            {
                p.attack(c);
            }

            if (e.KeyCode == Keys.E)
            {
                foreach (Item i in ItemHandler.getItems())
                {
                    if (p.getEntity().Bounds.IntersectsWith(i.getPbox().Bounds))
                    {
                        if (!p.pickupItem(i,c))
                        {
                            MessageBox.Show("Dein Inventar ist voll");
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

        }
        public static void KeyUp(Panel panel, KeyEventArgs e, Player p,Control c)
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
            if (e.KeyCode == Keys.Space)
            {
                AnimationHandler.deleteAnimation(c);
            }

        }
        public static void Update(Panel panel,EventArgs e,Player player,Control c)
        {

            AnimationHandler.setLocation(player,Inventory.Inventory.getaItem());
            CollisionHandler.calculatePlayerHit(player,c);
            foreach (LivingEntity le in LivingEntityHandler.getLivingEntitys())
            {

                CollisionHandler.calculateCollisions(panel, le, Barrier.getBarrierList());


                PictureBox p = le.getEntity();

                int speed = le.getSpeed();
                if (le is Enemy)
                {
                    Enemy en = le as Enemy;
                    if (CollisionHandler.calculatePlayerCollisions(panel, le, player))
                    {

                        if (en.getEntity().Visible)
                        {

                            if (player.Damage(en.getDamage(), c))
                        {
                            if (c is Form)
                            {

                                Form f = c as Form;
                                f.Close();
                                Menu m = new Menu();
                                m.Show();
                                MessageBox.Show("Game over");
                            }
                        }
                    }
                    }
                    else
                    {
                        en.followTarget();
                    }

                }
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
