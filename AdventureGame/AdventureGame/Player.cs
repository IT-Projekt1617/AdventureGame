using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    class Player
    {
        private static PictureBox p;
        private static int s;

        public Player(PictureBox player,int speed)
        {
            p = player;
            s = speed;
        }

        public void setPlayer(PictureBox player)
        {
            p = player;
        }

        public static PictureBox getPlayer()
        {
            return p;
        }
        public void setSpeed(int speed)
        {
            s = speed;
        }

        public static int getSpeed()
        {
            return s;
        }

    }
}
