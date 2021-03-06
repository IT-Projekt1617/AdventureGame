﻿using AdventureGame.Enity;
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
    public partial class Level_05cs : Form
    {

        Player p;
        Door d;
        Zombie Boss;
        public Level_05cs()
        {
            InitializeComponent();
        }

        private void Level_05cs_Load(object sender, EventArgs e)
        {

            p = new Player(player, 10, 20, 20, 0, null);
            d = new Door(this, new Menu(), false, Properties.Resources.treasure_open_blue, Properties.Resources.treasure_closed_blue, door);

            timer1.Start();
            Door.Timerlist.Add(timer1);
            timer2.Start();
            Door.Timerlist.Add(timer2);
            Inventory.Inventory.aSlot = 1;
            Inventory.Inventory.ps1 = Slot1;
            Inventory.Inventory.ps2 = Slot2;
            Inventory.Inventory.ps3 = Slot3;

            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier3);
            Barrier.addBarrier(barrier8);
            Barrier.addBarrier(pictureBox1);
            Barrier.addBarrier(pictureBox10);
            Barrier.addBarrier(pictureBox11);
            Barrier.addBarrier(pictureBox2);
            Barrier.addBarrier(pictureBox3);
            Barrier.addBarrier(pictureBox4);
            Barrier.addBarrier(pictureBox5);
            Barrier.addBarrier(pictureBox6);
            Barrier.addBarrier(pictureBox7);
            Barrier.addBarrier(pictureBox8);
            Barrier.addBarrier(pictureBox9);

            Boss = new Zombie(enemy1, 6, 100, 100, 6, new HealthPotion("Health Potion", 100, Properties.Resources.Hpotion, null), null, p.getEntity());

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            CustomEventHandler.Update2(d, this);
        }

        private void Level_05cs_KeyDown(object sender, KeyEventArgs e)
        {

            CustomEventHandler.KeyDown(e, p, this);
        }

        private void Level_05cs_KeyUp(object sender, KeyEventArgs e)
        {

            CustomEventHandler.KeyUp(panel1, e, p, this);
        }
    }
}
