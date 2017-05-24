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
        private static PictureBox e;
        private static int mhp;
        private static int hp;
        private static int s;
        private static string tp;
        private static int d;

        public LivingEntity(PictureBox entity, int speed, int maxhealth, int health, int damage, string texturepath)
        {
            e = entity;
            s = speed;
            mhp = maxhealth;
            hp = health;
            tp = texturepath;
            d = damage;
            //e.Image = Image.FromFile(texturepath);

        }

        protected void setEntity(PictureBox entity)
        {
            e = entity;
        }

        protected PictureBox getEntity()
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
            d = damage;
        }

        public int getDamage()
        {
            return d;
        }

    }
}
