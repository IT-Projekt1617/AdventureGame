using AdventureGame.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Handler
{
    class LivingEntityHandler
    {
        private static List<LivingEntity> LivingEntitylist = new List<LivingEntity>();
        private static List<Control> LivingEntityPBlist = new List<Control>();
        private static List<Enemy> Enemylist = new List<Enemy>();

        public static void addLivingEntity(LivingEntity le)
        {
            LivingEntitylist.Add(le);
            LivingEntityPBlist.Add(le.getEntity());
        }

        public static bool removeLivingEntity(LivingEntity le)
        {
            if (LivingEntitylist.Contains(le))
            {
                LivingEntitylist.Remove(le);
                LivingEntityPBlist.Remove(le.getEntity());
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void clearLivingEntityList()
        {
            LivingEntitylist.Clear();
            LivingEntityPBlist.Clear();
        }

        public static List<LivingEntity> getLivingEntitys()
        {
            return LivingEntitylist;
        }

        public static List<Control> getLivingEntitysPB()
        {
            return LivingEntityPBlist;
        }

        public static void addEnemy(Enemy le)
        {
            Enemylist.Add(le);
        }

        public static bool removeEnemy(Enemy le)
        {
            if (Enemylist.Contains(le))
            {
                Enemylist.Remove(le);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void clearEnemyList()
        {
            Enemylist.Clear();
        }

        public static List<Enemy> getEnemys()
        {
            return Enemylist;
        }

        public static void reduceHurtDelay()
        {
            foreach (LivingEntity le in LivingEntitylist)
            {
                if (le.getHurtdelay()>0)
                {
                    le.setHurtDelay(le.getHurtdelay()-1);
                }
            }
        }
    }
}
