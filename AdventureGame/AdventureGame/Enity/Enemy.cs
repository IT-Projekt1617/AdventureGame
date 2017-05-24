using AdventureGame.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Enity
{
    class Enemy : LivingEntity
    {
        private PictureBox t;

        public Enemy(PictureBox entity, int speed, int maxhealth, int health, int damage, string texturepath,PictureBox target) : base(entity, speed, maxhealth, health, damage, texturepath)
        {
            LivingEntityHandler.addEnemy(this);
        }

        public void setEnemy(PictureBox enemy)
        {
            base.setEntity(enemy);
        }
        public PictureBox getEnemyr()
        {
            return base.getEntity();
        }
        public void setTarget(PictureBox target)
        {
            t = target;
        }
        public PictureBox getTarget()
        {
            return t;
        }
    }
}
