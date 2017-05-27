using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    class Player : LivingEntity
    {
        

        public Player(PictureBox player, int speed, int maxhealth, int health, int damage, Bitmap texturepath) : base (player, speed, maxhealth, health, damage, texturepath)
        {

        }

        public void setPlayer(PictureBox player)
        {
            base.setEntity(player);
        }
        public PictureBox getPlayer()
        {
            return base.getEntity();
        }

    }
}
