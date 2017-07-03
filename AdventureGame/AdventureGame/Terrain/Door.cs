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
                p.Image = oT;
            }
            else
            {
                p.Image = cT;
            }

        }

        public Boolean isOpen()
        {
            return o;
        }

        public void setOpen()
        {
            o = true;
            p.Image = oT;

        }
        public void setClosed()
        {
            o = false;
            p.Image = cT;
        }

        public void testforNextLevel(Player player)
        {
            if (isOpen())
            {
                if (player.getEntity().Bounds.IntersectsWith(p.Bounds))
                {
                    nL.Show();
                    L.Close();
                }
            }
        }

    }
}
