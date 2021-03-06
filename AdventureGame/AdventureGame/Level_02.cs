﻿using AdventureGame.Enity;
using AdventureGame.Handler;
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
    public partial class Level_02 : Form
    {

        Player p;
        Door d;
        Zombie z;
        Ghost g;
        public Level_02()
        {
            InitializeComponent();
          
        }

        private void Level_02_Load(object sender, EventArgs e)
        {
            p = new Player(player, 10, 20, 20, 0, null);
            d = new Door(this, new Level_03(), false, Properties.Resources.opendoor, Properties.Resources.closeddoor, door);
            z = new Zombie(enemy1, 3, 10, 10, 2, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());
            g = new Ghost(ghost1, 1, 8,8, 2, new Bomb("Bomb", 20, 150, 100, Properties.Resources.bomb, "..\\..\\Resources\\explosion.png"), null, p.getEntity());
            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier2);
            Barrier.addBarrier(barrier3);
            Barrier.addBarrier(barrier4);
            Barrier.addBarrier(barrier5);
            Barrier.addBarrier(barrier6);
            Barrier.addBarrier(barrier7);
            Barrier.addBarrier(barrier8);


            Sword testsword = new Sword("Testsword", Properties.Resources.langschwert, "..\\..\\Resources\\langschwert.png", 3);
            testsword.drop(50, 550, this);

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
                p.setTexturepath(Properties.Resources.kuro_chibi);
            }
            else if (CharSelect.Char == 1)
            {
                p.setTexturepath(Properties.Resources.shiro_chibi);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CustomEventHandler.Update(label7, panel1, e, p, d, this);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            CustomEventHandler.Update2(d, this);
        }

        private void Level_02_KeyDown(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyDown(e, p, this);
        }

        private void Level_02_KeyUp(object sender, KeyEventArgs e)
        {

            CustomEventHandler.KeyUp(panel1, e, p, this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
