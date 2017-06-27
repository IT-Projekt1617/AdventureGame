using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.Inventory
{
    class Inventory
    {
        /*
        private int activeSlot;

        private Item Slot1;
        private Item Slot2;
        private Item Slot3;

        private PictureBox pSlot1;
        private PictureBox pSlot2;
        private PictureBox pSlot3;*/


        public Inventory() { }

        public static int aSlot { get; set; }
        public static Item s1 { get; set; }
        public static Item s2 { get; set; }
        public static Item s3 { get; set; }
        public static PictureBox ps1 { get; set; }
        public static PictureBox ps2 { get; set; }
        public static PictureBox ps3 { get; set; }

        public static Item getaItem()
        {
            if (aSlot == 1)
            {
                return s1;
            }
            if (aSlot == 2)
            {
                return s2;
            }
            if (aSlot == 3)
            {
                return s3;
            }
            return null;
        }
    }
}
