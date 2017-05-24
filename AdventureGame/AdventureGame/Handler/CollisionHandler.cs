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


        private static bool oben = false;
        private static bool unten = false;
        private static bool rechts = false;
        private static bool links = false;
        private static bool btrl = false;
        private static bool btou = false;
        private static bool innen = false;
        private static Control collidedBox = null;

        public static void calculateCollisions(Panel panel, LivingEntity le, List<Control> Barrierlist)
        {
            PictureBox p = le.getEntity();
            int speed = le.getSpeed();


            //Barrier
            IEnumerable<Control> barrierCollection = Barrierlist.Where(control => control.GetType() == typeof(PictureBox));
            bool isColliding = barrierCollection.Any(PictureBox => p.Bounds.IntersectsWith(PictureBox.Bounds));

            bool collision = false;

            if (isColliding)
            {
                collidedBox = barrierCollection.FirstOrDefault(PictureBox => p.Bounds.IntersectsWith(PictureBox.Bounds));

                if (p.Bounds.IntersectsWith(collidedBox.Bounds))

                {
                    collision = true;

                }
                else
                {
                    collision = false;
                }

            }
            else
            {
                collidedBox = null;
                oben = false;
                unten = false;
                rechts = false;
                links = false;
                btrl = false;
                btou = false;
                innen = false;
            }

            if (collision)
            {

                if (p.Bottom < collidedBox.Top + speed)
                {
                    oben = true;
                }
                else
                {
                    oben = false;
                }
                if (p.Top > collidedBox.Bottom - speed)
                {
                    unten = true;
                }
                else
                {
                    unten = false;
                }
                if (p.Left > collidedBox.Right - speed)
                {
                    rechts = true;
                }
                else
                {
                    rechts = false;
                }
                if (p.Right < collidedBox.Left + speed)
                {
                    links = true;
                }
                else
                {
                    links = false;
                }
                if (!rechts && !links)
                {
                    btrl = true;
                }
                else
                {
                    btrl = false;
                }
                if (!oben && !unten)
                {
                    btou = true;
                }
                else
                {
                    btou = false;
                }
                /* if (btou && btrl)
                 {
                     innen = true;
                 }
                 else
                 {
                     innen = false;
                 }*/

                //Barrier Up


                if (unten && btrl)
                {
                    le.setCollideUp(true);
                    p.Top = collidedBox.Bottom + 1;
                }
                else
                {
                    le.setCollideUp(false);
                }

                //Barrier Down

                if (oben && btrl)
                {
                    le.setCollideDown(true);
                    p.Top = collidedBox.Top - p.Height - 1;
                }
                else
                {
                    le.setCollideDown(false);
                }

                //Barrier Left

                if (rechts && btou)
                {
                    le.setCollideLeft(true);
                    p.Left = collidedBox.Right + 1;
                }
                else
                {
                    le.setCollideLeft(false);
                }


                //Barrier Right

                if (links && btou)
                {
                    le.setCollideRight(true);
                    p.Left = collidedBox.Left - p.Width - 1;
                }
                else
                {
                    le.setCollideRight(false);
                }

                //falls reingeglicht

                if (innen)
                {
                    //p.Top = collidedBox.Bottom + 1;
                }

            }
            else
            {
                le.setCollideDown(false);
                le.setCollideLeft(false);
                le.setCollideRight(false);
                le.setCollideUp(false);
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

    }
}
