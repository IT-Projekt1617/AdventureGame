using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Handler
{
    enum Location { TOP, BOT, RIGHT, LEFT };
    class AnimationHandler
    {
        
        private static int animationCD = 0;
        public static PictureBox activeanimation;
        private static Location loc { get; set; }

        public static void setLocationType(Location l)
        {
                loc = l;
        }

        public static void setLocation(Player p,Item i)
        {
            if (activeanimation!=null) {


            if (loc == Location.TOP)
            {
                    try
                    {
                        Image im = Image.FromFile(i.getPath());
                        activeanimation.Image = RotateImage(im, 0);
                        activeanimation.Location = new Point(p.getEntity().Location.X + (activeanimation.Width / 2), p.getEntity().Top - activeanimation.Height);



                    }
                    catch { } }
            else if (loc == Location.BOT)
            {

                    try
                    {
                        Image im = Image.FromFile(i.getPath());
                        activeanimation.Image = RotateImage(im, 180);
                        activeanimation.Location = new Point(p.getEntity().Location.X + (activeanimation.Width / 2), p.getEntity().Bottom);

                    }
                    catch { }
            }
            else if (loc == Location.RIGHT)
            {
                    try
                    {
                        Image im = Image.FromFile(i.getPath());
                        activeanimation.Image = RotateImage(im, 90);
                        activeanimation.Location = new Point(p.getEntity().Right, p.getEntity().Location.Y + (activeanimation.Height / 2));

                    }
                    catch { }
            }
            else if (loc == Location.LEFT)
            {

                    try
                    {
                        Image im = Image.FromFile(i.getPath());
                        activeanimation.Image = RotateImage(im, 270);
                        activeanimation.Location = new Point(p.getEntity().Left - activeanimation.Width, p.getEntity().Location.Y + (activeanimation.Height / 2));


                    }
                    catch { } }
        }
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        public static void attackAnimation(Item i, Player p, Control c)
        {
            if (activeanimation == null)
            {
                var picture = new PictureBox
                {
                    Name = i.getName(),
                    Size = new Size(32, 32),
                    Image = i.getTexturepath(),
                    BorderStyle = BorderStyle.None

                };

                activeanimation = picture;
                setLocation(p,i);
                c.Controls.Add(picture);
                picture.BringToFront();

            }
            else
            {
                setLocation(p,i);
            }
        }

        public static void bombAnimation(int x, int y,Bomb b, Control c)
        {
            if (activeanimation == null)
            {
                var picture = new PictureBox
                {
                    Name = b.getName(),
                    Size = new Size(b.getRadius(), b.getRadius()),
                    Image = Image.FromFile(b.getPath()),
                    BorderStyle = BorderStyle.None,
                    Location = new Point(x, y)

                };
                activeanimation = picture;
                c.Controls.Add(picture);
                picture.BringToFront();
                animationCD = 3;

            }
        }

        public static void deleteAnimation(Control c)
        {
            if (activeanimation!=null)
            {
                c.Controls.Remove(activeanimation);
                activeanimation.Dispose();
                activeanimation = null;
            }
        }


        public static int getCD()
        {
            return animationCD;
        }

        public static void setCD(int value)
        {
            animationCD = value;
        }

        public static void reduceanimationCD(Control c)
        {
            if (getCD()>0)
            {
                setCD(getCD()-1);
                if (getCD()==0)
                {
                    deleteAnimation(c);
                }
            }
        }
    }
}
