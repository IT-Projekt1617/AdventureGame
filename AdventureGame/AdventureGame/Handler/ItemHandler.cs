﻿using AdventureGame.Items;
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
    }
}