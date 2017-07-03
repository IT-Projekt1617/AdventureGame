using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Items
{
    class HealthPotion : Item
    {
        private int h;

        public HealthPotion(string name,int heal, Bitmap texturepath, string imagepath) : base(name, texturepath, imagepath)
        {
            h = heal;
        }

        public void use(Player p)
        {
            if (p.getHealth() + h <= p.getmaxHealth())
            {
                p.setHealth(p.getHealth()+h);
            }
            else
            {
                p.setHealth(p.getmaxHealth());
            }
            Inventory.Inventory.removeaItem();
        }
    }
}
