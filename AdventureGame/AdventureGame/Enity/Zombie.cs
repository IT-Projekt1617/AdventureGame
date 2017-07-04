using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureGame.Items;

namespace AdventureGame.Enity
{
    class Zombie : Enemy
    {
        public Zombie(PictureBox entity, int speed, int maxhealth, int health, int damage, Item Loot, Bitmap texturepath, PictureBox target) : base(entity, speed, maxhealth, health, damage, Loot, texturepath, target)
        {
        }
    }
}
