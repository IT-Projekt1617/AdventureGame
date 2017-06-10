using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdventureGame.Inventory;

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

        public Boolean pickupItem(Item i,Control c)
        {
            if (Inventory.Inventory.s1 == null)
            {
                Inventory.Inventory.s1 = i;
                c.Controls.Remove(i.getPbox());
                i.getPbox().Dispose();
                return true;
            }
            if (Inventory.Inventory.s2 == null)
            {

                Inventory.Inventory.s2 = i;
                c.Controls.Remove(i.getPbox());
                i.getPbox().Dispose();
                return true;
            }
            if (Inventory.Inventory.s3 == null)
            {

                Inventory.Inventory.s3 = i;
                c.Controls.Remove(i.getPbox());
                i.getPbox().Dispose();
                return true;
            }

            return false;
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
