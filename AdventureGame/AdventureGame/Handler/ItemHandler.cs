using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Handler
{
    class ItemHandler
    {
        private static List<Item> Itemlist = new List<Item>();
        private static List<Bomb> Bomblist = new List<Bomb>();

        public static void addItem(Item i)
        {
            Itemlist.Add(i);
        }

        public static bool removeItem(Item i)
        {
            if (Itemlist.Contains(i))
            {
                Itemlist.Remove(i);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void clearItemList()
        {
            Itemlist.Clear();
        }

        public static List<Item> getItems()
        {
            return Itemlist;
        }


        public static void addBomb(Bomb i)
        {
            Bomblist.Add(i);
        }

        public static bool removeBomb(Bomb i)
        {
            if (Bomblist.Contains(i))
            {
                Bomblist.Remove(i);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void clearBombList()
        {
            Bomblist.Clear();
        }

        public static List<Bomb> getBombs()
        {
            return Bomblist;
        }
    }
}
