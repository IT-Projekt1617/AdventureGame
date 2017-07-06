using AdventureGame.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdventureGame.Inventory;
using AdventureGame.Handler;
using AdventureGame.Enity;
using AdventureGame.Terrain;

namespace AdventureGame
{
    public partial class Level_01 : Form
    {
        

        Player p;
        Zombie z;
        Door d;
        public Level_01()
        {
            InitializeComponent();
               
        }

        

        private void Level_01_KeyDown(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyDown(e, p,this);

            
        }

        private void Level_01_KeyUp(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyUp(panel1,e, p,this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CustomEventHandler.Update(label7,panel1,e,p,d,this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void Level_01_Load(object sender, EventArgs e)
        {


            p = new Player(player, 10, 20, 20, 0, null);
            z = new Zombie(enemy1, 3, 10, 10, 2, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());
            z = new Zombie(enemy2, 2, 10, 10, 2, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());
            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier2);
            Barrier.addBarrier(barrier3);
            Barrier.addBarrier(barrier4);
            Barrier.addBarrier(barrier6);
            Barrier.addBarrier(barrier7);
            Barrier.addBarrier(barrier8);
            Barrier.addBarrier(barrier);


            d = new Door(this, new Level_02(), false, Properties.Resources.opendoor, Properties.Resources.closeddoor, door);

            timer1.Start();
            Door.Timerlist.Add(timer1);
            timer2.Start();
            Door.Timerlist.Add(timer2);

            Sword testsword = new Sword("Testsword",Properties.Resources.dolch, "..\\..\\Resources\\dolch.png", 100);
            testsword.drop(50, 550,this);


            
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Inventory.Inventory.aSlot = 2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CustomEventHandler.Update2(d,this);
        }

        private void Slot1_Click(object sender, EventArgs e)
        {
            Inventory.Inventory.aSlot = 1;
        }

        private void Slot3_Click(object sender, EventArgs e)
        {
            Inventory.Inventory.aSlot = 3;

        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void barrier2_Click(object sender, EventArgs e)
        {

        }

        private void barrier1_Click(object sender, EventArgs e)
        {

        }

        private void ghost1_Click(object sender, EventArgs e)
        {

        }

        private void barrier5_Click(object sender, EventArgs e)
        {

        }
    }
}
