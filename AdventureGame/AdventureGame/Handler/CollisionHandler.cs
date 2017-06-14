using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Handler
{
    class CollisionHandler
    {

        private static Control collidedBox = null;

        public static void calculateCollisions(Panel panel, LivingEntity le, List<Control> Barrierlist)
        {
            PictureBox p = le.getEntity();
            int speed = le.getSpeed();


            //Barrier
            IEnumerable<Control> barrierCollection = Barrierlist.Where(control => control.GetType() == typeof(PictureBox));
            bool isColliding = barrierCollection.Any(PictureBox => p.Bounds.IntersectsWith(PictureBox.Bounds));
                if (isColliding)
                {
                    collidedBox = barrierCollection.FirstOrDefault(PictureBox => p.Bounds.IntersectsWith(PictureBox.Bounds));

                    if (p.Bounds.IntersectsWith(collidedBox.Bounds))

                    {
                    if (le.getDown())
                    {
                        le.setDown(false);
                        le.setCollideDown(true);
                        p.Top -= (speed);
                        //p.Top = collidedBox.Top - p.Height - (speed+1);
                    }
                    if (le.getUp())
                    {
                        le.setUp(false);
                        le.setCollideUp(true);
                        p.Top += (speed);
                        //p.Top = collidedBox.Bottom + (speed + 1);
                    }
                    if (le.getLeft())
                    {
                        le.setLeft(false);
                        le.setCollideLeft(true);
                        p.Left += (speed*2);
                        //p.Left = collidedBox.Right + (speed + 1);
                    }
                    if (le.getRight())
                    {
                        le.setRight(false);
                        le.setCollideRight(true);
                        p.Left -= (speed);
                        //p.Left = collidedBox.Left - p.Width - (speed + 1);
                    }

                }
                    else
                    {
                    
                    }

                }
                else
                {
                    collidedBox = null;
                }


            //Panel

            //Panel Left

            if (p.Left < panel.Left + speed)
            {
                le.setCollideLeft(true);
            }
            else
            {
                le.setCollideLeft(false);
            }

            //Panel Right

            if (p.Right > panel.Right - 2 * speed)
            {
                le.setCollideRight(true);
            }
            else
            {
                le.setCollideRight(false);
            }

            //Panel Up

            if (p.Top < panel.Top + speed)
            {
                le.setCollideUp(true);
            }
            else
            {
                le.setCollideUp(false);
            }

            //Panel Down

            if (p.Bottom > panel.Bottom - speed)
            {
                le.setCollideDown(true);
            }
            else
            {
                 le.setCollideDown(false);
            }
        }

        public static Boolean calculatePlayerCollisions(Panel panel, LivingEntity le, Player pl)
        {
            PictureBox p = le.getEntity();
            int speed = le.getSpeed();

         
            bool isColliding = p.Bounds.IntersectsWith(pl.getEntity().Bounds);
            if (isColliding)
            {
                collidedBox = pl.getEntity();

                if (p.Bounds.IntersectsWith(collidedBox.Bounds))

                {
                    if (le.getDown())
                    {
                        le.setDown(false);
                        le.setCollideDown(true);
                        p.Top -= (speed);
                        //p.Top = collidedBox.Top - p.Height - (speed+1);
                    }
                    if (le.getUp())
                    {
                        le.setUp(false);
                        le.setCollideUp(true);
                        p.Top += (speed);
                        //p.Top = collidedBox.Bottom + (speed + 1);
                    }
                    if (le.getLeft())
                    {
                        le.setLeft(false);
                        le.setCollideLeft(true);
                        p.Left += (speed * 2);
                        //p.Left = collidedBox.Right + (speed + 1);
                    }
                    if (le.getRight())
                    {
                        le.setRight(false);
                        le.setCollideRight(true);
                        p.Left -= (speed);
                        //p.Left = collidedBox.Left - p.Width - (speed + 1);
                    }

                }
                else
                {

                }
            }
            else
            {
                collidedBox = null;
            }


            //Panel

            //Panel Left

            if (p.Left < panel.Left + speed)
            {
                le.setCollideLeft(true);
            }
            else
            {
                le.setCollideLeft(false);
            }

            //Panel Right

            if (p.Right > panel.Right - 2 * speed)
            {
                le.setCollideRight(true);
            }
            else
            {
                le.setCollideRight(false);
            }

            //Panel Up

            if (p.Top < panel.Top + speed)
            {
                le.setCollideUp(true);
            }
            else
            {
                le.setCollideUp(false);
            }

            //Panel Down

            if (p.Bottom > panel.Bottom - speed)
            {
                le.setCollideDown(true);
            }
            else
            {
                le.setCollideDown(false);
            }

            if (isColliding)
            {

                return true;
            }
            else return false;
        }


    }
}


