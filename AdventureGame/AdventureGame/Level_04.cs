using AdventureGame.Items;
using AdventureGame.Terrain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Level_04 : Form
    {


        Player p;
        Door d;
        public Level_04()
        {
            InitializeComponent();
        }

        private void Level_04_Load(object sender, EventArgs e)
        {

            p = new Player(player, 10, 20, 20, 0, null);
            d = new Door(this, new Level_05cs(), false, Properties.Resources.opendoor, Properties.Resources.closeddoor, door);

            timer1.Start();
            Door.Timerlist.Add(timer1);
            timer2.Start();
            Door.Timerlist.Add(timer2);
            Inventory.Inventory.aSlot = 1;
            Inventory.Inventory.ps1 = Slot1;
            Inventory.Inventory.ps2 = Slot2;
            Inventory.Inventory.ps3 = Slot3;

            if (CharSelect.Char == 2)
            {
                p.setTexturepath(Properties.Resources.Ch_cho_img_03);
            }
            else if (CharSelect.Char == 1)
            {
                p.setTexturepath(Properties.Resources.Ch_van_img_03);

            }
            
            Sword testsword = new Sword("Testsword", Properties.Resources.dolch, "..\\..\\Resources\\dolch.png", 2);
            testsword.drop(1260, 675, this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            CustomEventHandler.Update(label7, panel1, e, p, d, this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            CustomEventHandler.Update2(d, this);
        }

        private void Level_04_KeyDown(object sender, KeyEventArgs e)
        {

            CustomEventHandler.KeyDown(e, p, this);
        }

        private void Level_04_KeyUp(object sender, KeyEventArgs e)
        {

            CustomEventHandler.KeyUp(panel1, e, p, this);
        }
    }
}
