using AdventureGame.Handler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Terrain
{
    class Door
    {
        private Form L;
        private Form nL;
        private Boolean o;
        private Bitmap oT;
        private Bitmap cT;
        private PictureBox p;

        public static List<Timer> Timerlist = new List<Timer>();

        public Door(Form Level,Form nextLevel,Boolean open,Bitmap openT,Bitmap closedT,PictureBox pb)
        {
            L = Level;
            nL = nextLevel;
            o = open;
            oT = openT;
            cT = closedT;
            p = pb;
            if (o)
            {
                p.BackgroundImage = oT;
            }
            else
            {
                p.BackgroundImage = cT;
            }

        }

        public Boolean isOpen()
        {
            return o;
        }

        public void setOpen()
        {
            o = true;
            p.BackgroundImage = oT;

        }
        public void setClosed()
        {
            o = false;
            p.BackgroundImage = cT;
        }

        public void testforNextLevel(Player player)
        {
            if (isOpen())
            {
                if (player.getEntity().Bounds.IntersectsWith(p.Bounds))
                {

                    Barrier.getBarrierList().Clear();
                    LivingEntityHandler.clearLivingEntityList();
                    LivingEntityHandler.clearEnemyList();
                    ItemHandler.clearBombList();
                    ItemHandler.clearItemList();

                    foreach (Timer l in Timerlist)
                    {
                        l.Stop();
                    }

                    Timerlist.Clear();
                    nL.Show();
                    L.Close();
                }
            }
        }

    }
}
