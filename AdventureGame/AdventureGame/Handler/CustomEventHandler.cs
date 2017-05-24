using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    class CustomEventHandler
    {
        private static bool right = false;
        private static bool left = false;
        private static bool up = false;
        private static bool down = false;

        private static bool collideright = false;
        private static bool collideleft = false;
        private static bool collideup = false;
        private static bool collidedown = false;


        private static bool oben = false;
        private static bool unten = false;
        private static bool rechts = false;
        private static bool links = false;
        private static bool btrl = false;
        private static bool btou = false;
        private static bool innen = false;

        private static Control collidedBox = null;


        public static void KeyDown(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                up = true;
            }

            if (e.KeyCode == Keys.S)
            {
                down = true;
            }

            if (e.KeyCode == Keys.A)
            {
                left = true;
            }

            if (e.KeyCode == Keys.D)
            {
                right = true;
            }

        }
        public static void KeyUp(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                up = false;
            }

            if (e.KeyCode == Keys.S)
            {
                down = false;
            }

            if (e.KeyCode == Keys.A)
            {
                left = false;
            }

            if (e.KeyCode == Keys.D)
            {
                right = false;
            }

        }
        public static void Update(EventArgs e,Player player)
        {
            int speed = player.getSpeed();
            PictureBox p = player.getPlayer();

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

            if (up&&!collideup)
            {
                p.Top-= speed;
            }
            else
            {
                up = false;
            }
            if (down&&!collidedown)
            {
                p.Top += speed;
            }
            else
            {
                down = false;
            }
            if (right&&!collideright)
            {
                p.Left += speed;
            }
            else
            {
                right = false;
            }
            if (left&&!collideleft)
            {
                p.Left -= speed;
            }
            else
            {
                left = false;
            }
        }

        public static void PaintEvent(Panel panel, PaintEventArgs e,Player player)
        {
            PictureBox p = player.getPlayer();
            int speed = player.getSpeed();

            //Barrier
            List<Control> Barrierlist = Barrier.getBarrierList();
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
                    collideup = true;
                    p.Top = collidedBox.Bottom + 1;
                }
                else
                {
                    collideup = false;
                }

                //Barrier Down

                if (oben && btrl)
                {
                    collidedown = true;
                    p.Top = collidedBox.Top - p.Height - 1;
                }
                else
                {
                    collidedown = false;
                }

                //Barrier Left

                if (rechts && btou)
                {
                    collideleft = true;
                    p.Left = collidedBox.Right + 1;
                }
                else
                {
                    collideleft = false;
                }


                //Barrier Right

                if (links && btou)
                {
                    collideright = true;
                    p.Left = collidedBox.Left - p.Width-1;
                }
                else
                {
                    collideright = false;
                }

                //falls reingeglicht

                if (innen)
                {
                    //p.Top = collidedBox.Bottom + 1;
                }

            }
            else
            {
                collidedown = false;
                collideleft = false;
                collideright = false;
                collideup = false;
            }



            //Panel

            //Panel Left

            if (p.Left < panel.Left + speed)
            {
                collideleft = true;
            }
            else
            {
                collideleft = false;
            }

            //Panel Right

            if (p.Right > panel.Right - 2 * speed)
            {
                collideright = true;
            }
            else
            {
                collideright = false;
            }

            //Panel Up

            if (p.Top < panel.Top + speed)
            {
                collideup = true;
            }
            else
            {
                collideup = false;
            }

            //Panel Down

            if (p.Bottom > panel.Bottom - speed)
            {
                collidedown = true;
            }
            else
            {
                collidedown = false;
            }
        }


    }
}
