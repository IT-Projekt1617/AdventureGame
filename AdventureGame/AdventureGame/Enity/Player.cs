﻿using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdventureGame.Inventory;
using AdventureGame.Handler;

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

        public Boolean Damage(int damage, Control c)
        {
            
            if (base.damage(damage, c))
            {
                return true;
            }
            return false;
        }


        private void doattackAnimation(Item i, Control c)
        {
            AnimationHandler.attackAnimation(i,this,c);
        }

        public void attack(Control c)
        {
            Item aItem = Inventory.Inventory.getaItem();
                if (aItem != null)
                {
                  if (aItem is Sword)
                  {
                    doattackAnimation(aItem, c);

                  }else if (aItem is HealthPotion)
                  {
                    HealthPotion hp = aItem as HealthPotion;
                    hp.use(this);
                  }else if (aItem is Bomb)
                {
                    Bomb b = aItem as Bomb;
                    b.use(this, c);
                }
                }  
        }


        public Boolean pickupItem(Item i,Control c)
        {

            if (c.Controls.Contains(i.getPbox()))
            {

                if (Inventory.Inventory.s1 == null)
                {

                    c.Controls.Remove(i.getPbox());
                    i.getPbox().Dispose();
                    Inventory.Inventory.s1 = i;
                    return true;
                }
                if (Inventory.Inventory.s2 == null)
                {

                    c.Controls.Remove(i.getPbox());
                    i.getPbox().Dispose();

                    Inventory.Inventory.s2 = i;
                    return true;
                }
                if (Inventory.Inventory.s3 == null)
                {

                    c.Controls.Remove(i.getPbox());
                    i.getPbox().Dispose();
                    Inventory.Inventory.s3 = i;
                    return true;
                }

                return false;
            }

            return true;

        }

        public void dropItem(Control c)
        {
            if (Inventory.Inventory.aSlot!=0)
            {
                if (Inventory.Inventory.aSlot==1)
                {
                    if (Inventory.Inventory.s1!=null)
                    {
                        Item i = Inventory.Inventory.s1;
                        Inventory.Inventory.s1 = null;
                        i.drop(getEntity().Location.X+(getEntity().Width/2), getEntity().Location.Y + (getEntity().Height/2), c);
                    }
                }
                else if (Inventory.Inventory.aSlot == 2)
                {
                    if (Inventory.Inventory.s2 != null)
                    {
                        Item i = Inventory.Inventory.s2;
                        Inventory.Inventory.s2 = null;
                        i.drop(getEntity().Location.X + (getEntity().Width / 2), getEntity().Location.Y + (getEntity().Height / 2), c);
                    }

                }
                else if (Inventory.Inventory.aSlot == 3)
                {
                    if (Inventory.Inventory.s3 != null)
                    {
                        Item i = Inventory.Inventory.s3;
                        Inventory.Inventory.s3 = null;
                        i.drop(getEntity().Location.X + (getEntity().Width / 2), getEntity().Location.Y + (getEntity().Height / 2), c);
                    }

                }
            }
        }
    }
}
