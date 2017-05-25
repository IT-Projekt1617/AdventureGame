using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Inventory
{
    class InventoryManager
    {
        private static List<Item> Inventorylist = new List<Item>();

        public static void addItem(Item i)
        {
            Inventorylist.Add(i);
        }

        public static bool removeItem(Item i)
        {
            if (Inventorylist.Contains(i))
            {
                Inventorylist.Remove(i);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void clearInventoryList()
        {
            Inventorylist.Clear();
        }

        public static List<Item> getItems()
        {
            return Inventorylist;
        }
    }

}
