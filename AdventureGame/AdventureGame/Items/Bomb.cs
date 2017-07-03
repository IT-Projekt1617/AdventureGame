using AdventureGame.Enity;
using AdventureGame.Handler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Items
{
    class Bomb : Item
    {
        private int d;
        private int cd;
        private Boolean inUse;
        private PictureBox pb;
        private int r;

        public Bomb(string name, int damage,int radius, int Cooldown, Bitmap texturepath, string imagepath) : base(name, texturepath, imagepath)
        {
            d = damage;
            cd = Cooldown;
            inUse = false;
            r = radius;
        }

        public void use(Player p, Control c)
        {
            Inventory.Inventory.removeaItem();

            var picture = new PictureBox
            {
                Name = getName(),
                Size = new Size(32, 32),
                Location = new Point(p.getEntity().Location.X, p.getEntity().Location.Y),
                Image = base.getTexturepath(),
                BorderStyle = BorderStyle.None

            };
            pb = picture;
            c.Controls.Add(picture);
            picture.BringToFront();
            ItemHandler.addBomb(this);
            inUse = true;
        }

        public void UpdateCD(Control c)
        {
            if (inUse)
            {
                if (cd-1>0)
                {
                    cd -= 1;
                }
                else
                {
                    inUse = false;
                    ItemHandler.removeBomb(this);
                    explode(c);
                }
            }
        }

        private void explode(Control c)
        {

            AnimationHandler.bombAnimation(this,c);

            try {
                foreach (LivingEntity le in LivingEntityHandler.getLivingEntitys())
                {
                    if (getDistance(le) <= r)
                    {
                        if (le is Enemy)
                        {
                            Enemy en = le as Enemy;
                            en.Damage(d, c);
                        }
                        if (le is Player)
                        {
                            Player p = le as Player;
                            if (p.Damage(d, c))
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
                }
            } catch
            {
                foreach (LivingEntity le in LivingEntityHandler.getLivingEntitys())
                {
                    if (getDistance(le) <= r)
                    {

                        if (le is Player)
                        {
                            Player p = le as Player;
                            p.Damage(d, c);
                        }
                        else if (le is Enemy)
                        {
                            Enemy en = le as Enemy;
                            en.Damage(d, c);
                        }
                    }
                }
            }
            

            c.Controls.Remove(pb);
            pb.Dispose();
            pb = null;

        }

        private double getDistance(LivingEntity le)
        {
            double x1 = le.getEntity().Location.X;
            double x2 = pb.Location.X;
            double y1 = le.getEntity().Location.Y;
            double y2 = pb.Location.Y;

            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

    }
}
