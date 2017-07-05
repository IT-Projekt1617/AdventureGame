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
    class Item
    {
        private string n;
        private Bitmap tp;
        private PictureBox p;
        private String path;

        public Item(string name, Bitmap texturepath, String imagepath)
        {
            n = name;
            tp = texturepath;
            path = imagepath;
            ItemHandler.addItem(this);

        }



        public void setTexturepath(Bitmap texturepath)
        {
            tp = texturepath;
        }

        public Bitmap getTexturepath()
        {
            return tp;
        }


        public String getPath()
        {
            return path;
        }

        public void setName(string name)
        {
            n = name;
        }

        public string getName()
        {
            return n;
        }

        public PictureBox getPbox()
        {
            return p;
        }

        public void drop(int x, int y,Control c)
        {
            var picture = new PictureBox
            {
                Name = getName(),
                Size = new Size(32, 32),
                Location = new Point(x, y),
                BackgroundImage = tp,
                BorderStyle = BorderStyle.Fixed3D,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent

            };
            p = picture;
            c.Controls.Add(picture);
            picture.BringToFront();
        }

        public void despawn(Control c)
        {
            c.Controls.Remove(p);
            p.Dispose();
        }
    }
}
