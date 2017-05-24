using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    class CustomEventHandler
    {
        public static bool right = false;
        public static bool left = false;
        public static bool up = false;
        public static bool down = false;

        public static bool collideright = false;
        public static bool collideleft = false;
        public static bool collideup = false;
        public static bool collidedown = false;
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
        public static void Update(EventArgs e)
        {
            int speed = Player.getSpeed();
            PictureBox p = Player.getPlayer();

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

        public static void PaintEvent(Panel panel, PaintEventArgs e)
        {
            PictureBox p = Player.getPlayer();
            int speed = Player.getSpeed();

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
                }

            if (collision)
            {
                bool oben = false;
                bool unten = false;
                bool rechts = false;
                bool links = false;
                bool btrl = false;
                bool btou = false;

                if (p.Bottom < collidedBox.Top + speed)
                {
                    oben = true;
                }
                if (p.Top > collidedBox.Bottom - speed)
                {
                    unten = true;
                }
                if (p.Left > collidedBox.Right - speed)
                {
                    rechts = true;
                }
                if (p.Right < collidedBox.Left + speed)
                {
                    links = true;
                }
                if (!rechts && !links)
                {
                    btrl = true;
                }
                if (!oben && !unten)
                {
                    btou = true;
                }

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
