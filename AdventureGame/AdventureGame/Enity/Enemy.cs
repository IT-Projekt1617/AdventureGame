using AdventureGame.Handler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Enity
{
    class Enemy : LivingEntity
    {
        private PictureBox t;

        public Enemy(PictureBox entity, int speed, int maxhealth, int health, int damage, Bitmap texturepath,PictureBox target) : base(entity, speed, maxhealth, health, damage, texturepath)
        {
            LivingEntityHandler.addEnemy(this);
        }

        public void setTarget(PictureBox target)
        {
            t = target;
        }

        public PictureBox getTarget()
        {
            return t;
        }

        public void followTarget()
        {
            if (t!=null) {
            if (t.Bottom < getEntity().Top)
            {
                if (!getCollideUp())
                {
                    setDown(false);
                    setUp(true);
                }
                else
                {
                    setUp(false);
                }
            }

            if (t.Top > getEntity().Bottom)
            {
                if (!getCollideDown())
                {
                    setUp(false);
                    setDown(true);
                }
                else
                {
                    setDown(false);
                }
            }

            if (t.Right < getEntity().Left)
            {
                if (!getCollideLeft())
                {
                    setRight(false);
                    setLeft(true);
                }
                else
                {
                    setLeft(false);
                }
            }

            if (t.Left > getEntity().Right)
            {
                if (!getCollideRight())
                {
                        setLeft(false);
                        setRight(true);
                }
                else
                {
                    setRight(false);
                }
            }

        }
        }


    }
}
