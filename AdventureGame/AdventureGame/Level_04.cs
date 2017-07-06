using AdventureGame.Enity;
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
        Zombie z;
        Zombie z2;
        Zombie z3;
        Zombie z4;

        public Level_04()
        {
            InitializeComponent();
        }

        private void Level_04_Load(object sender, EventArgs e)
        {

            p = new Player(player, 10, 20, 20, 0, null);
            d = new Door(this, new Level_05cs(), false, Properties.Resources.opendoor, Properties.Resources.closeddoor, door);

            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier2);
            Barrier.addBarrier(barrier3);
            Barrier.addBarrier(barrier4);
            Barrier.addBarrier(barrier5);
            Barrier.addBarrier(barrier6);
            Barrier.addBarrier(barrier7);
            Barrier.addBarrier(barrier8);

            z = new Zombie(enemy1, 3, 10, 10, 2, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());
            z2 = new Zombie(enemy2, 3, 10, 10, 2, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());
            z3 = new Zombie(enemy3, 3, 10, 10, 2, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());
            z4 = new Zombie(enemy4, 3, 10, 10, 2, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());

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
            
            Sword testsword = new Sword("Katana", Properties.Resources.katana, "..\\..\\Resources\\katana.png", 10);
            testsword.drop(1200, 620, this);
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
