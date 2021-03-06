﻿using AdventureGame.Handler;
using AdventureGame.Items;
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
        private Item loot;

        public Enemy(PictureBox entity, int speed, int maxhealth, int health, int damage,Item Loot, Bitmap texturepath,PictureBox target) : base(entity, speed, maxhealth, health, damage, texturepath)
        {
            loot = Loot;
            t = target;
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

        public void Damage(int damage, Control c)
        {
            if (base.damage(damage,c))
            {
                loot.drop(getEntity().Location.X, getEntity().Location.Y, c);
                LivingEntityHandler.removeEnemy(this);
            }
        }

        public void followTarget()
        {
            if(getEntity().Visible){
            if (t != null)
            {
                if (t.Bottom-10 < getEntity().Top)
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

                if (t.Top+10 > getEntity().Bottom)
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

                if (t.Right-10 < getEntity().Left)
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

                if (t.Left+10 > getEntity().Right)
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
}
