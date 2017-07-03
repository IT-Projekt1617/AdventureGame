using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    class Barrier
    {
        private static List<Control> Barrierlist = new List<Control>();

        public Barrier()
        {

        }

        public static void addBarrier(Control barrier)
        {
            Barrierlist.Add(barrier);
        }

        public static void removeBarrier(Control barrier)
        {
            Barrierlist.Remove(barrier);
        }

        public static List<Control> getBarrierList()
        {
            return Barrierlist;
        }
    }
}
