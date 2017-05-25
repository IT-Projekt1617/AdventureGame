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
        private string tp;
        private PictureBox p;

        public Item(string name,string texturepath, PictureBox pbox)
        {
            n = name;
            tp = texturepath;
            if (pbox == null)
            {
                p = new PictureBox();
            }
            else
            {
                p = pbox;
            }
            if (texturepath!=null)
            {
                p.Image = Image.FromFile(texturepath);
            }
            ItemHandler.addItem(this);

        }


        public void setTexturepath(string texturepath)
        {
            tp = texturepath;
        }

        public string getTexturepath()
        {
            return tp;
        }
        public void setName(string name)
        {
            n = name;
        }

        public string getName()
        {
            return n;
        }

        public void spawn(int x, int y)
        {

        }

        public void despawn()
        {
            p.Hide();
        }
    }
}
