using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Items
{
    class Sword : Item
    {
        private int d;

        public Sword(string name, Bitmap texturepath,String path, int damage) : base(name, texturepath,path)
        {
            d = damage;
        }

        public int getDamage()
        {
            return d;
        }
    }
}
