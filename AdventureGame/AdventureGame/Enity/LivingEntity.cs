using AdventureGame.Handler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    class LivingEntity
    {

        //Stats etc.
        private PictureBox e;
        private int mhp;
        private int hp;
        private int s;
        private string tp;
        private int dmg;

        //Movement

        private bool right = false;
        private bool left = false;
        private bool up = false;
        private bool down = false;

        //Collision

        private bool collideright = false;
        private bool collideleft = false;
        private bool collideup = false;
        private bool collidedown = false;

        public LivingEntity(PictureBox entity, int speed, int maxhealth, int health, int damage, string texturepath)
        {
            e = entity;
            s = speed;
            mhp = maxhealth;
            hp = health;
            tp = texturepath;
            dmg = dmgamage;
            LivingEntityHandler.addLivingEntity(this);
            //e.Image = Image.FromFile(texturepath);

        }

        public void setEntity(PictureBox entity)
        {
            e = entity;
        }

        public PictureBox getEntity()
        {
            return e;
        }
        public void setSpeed(int speed)
        {
            s = speed;
        }

        public int getSpeed()
        {
            return s;
        }
        public void setmaxHealth(int maxHealth)
        {
            mhp = maxHealth;
        }

        public int getmaxHealth()
        {
            return mhp;
        }
        public void setHealth(int health)
        {
            hp = health;
        }

        public int getHealth()
        {
            return hp;
        }
        public void setTexturepath(string texturepath)
        {
            tp = texturepath;
        }

        public string getTexturepath()
        {
            return tp;
        }
        public void setDamage(int damage)
        {
            dmg = damage;
        }

        public int getDamage()
        {
            return dmg;
        }

        public void setRight(bool value)
        {
            right = value;
        }
        public bool getRight()
        {
            return right;
        }

        public void setLeft(bool value)
        {
            left = value;
        }
        public bool getLeft()
        {
            return left;
        }

        public void setUp(bool value)
        {
            up = value;
        }
        public bool getUp()
        {
            return up;
        }

        public void setDown(bool value)
        {
            down = value;
        }
        public bool getDown()
        {
            return down;
        }

        public void setCollideRight(bool value)
        {
            collideright = value;
        }
        public bool getCollideRight()
        {
            return collideright;
        }

        public void setCollideLeft(bool value)
        {
            collideleft = value;
        }
        public bool getCollideLeft()
        {
            return collideleft;
        }

        public void setCollideUp(bool value)
        {
            collideup = value;
        }
        public bool getCollideUp()
        {
            return collideup;
        }

        public void setCollideDown(bool value)
        {
            collidedown = value;
        }
        public bool getCollideDown()
        {
            return collidedown;
        }

    }
}
