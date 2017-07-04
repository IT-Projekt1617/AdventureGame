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
        Ghost g;
        Door d;
        public Level_01()
        {
            InitializeComponent();

            p = new Player(player, 10, 20, 20, 0, null);
            z = new Zombie(enemy1,5,10,10,2,new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null),null,p.getEntity());
            g = new Ghost(ghost1, 2, 5, 5, 3, new HealthPotion("Health Potion", 5, Properties.Resources.Hpotion, null), null, p.getEntity());
            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier2);
            d = new Door(this,new Level_02(),true,Properties.Resources.opendoor, Properties.Resources.closeddoor, door);
               
        }

        

        private void Level_01_KeyDown(object sender, KeyEventArgs e)
        {
            CustomEventHandler.KeyDown(e, p,this);

            DialogResult result; 
            if (e.KeyCode == Keys.Escape)
            {
                 result= MessageBox.Show("Are you sure you wanna quit this 1337 game ?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Menu m =new Menu();
                    m.Visible = true;
                    this.Close();
                }
            }
            
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

            Sword testsword = new Sword("Testsword",Properties.Resources.sword, "..\\..\\Resources\\sword.png", 2);
            testsword.drop(250, 250,this);

            Bomb bomb = new Bomb("Bomb", 20, 150, 100, Properties.Resources.bomb, "..\\..\\Resources\\explosion.png");
            bomb.drop(500,500,this);
            
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
            //this.z.setTarget(p.getEntity());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Inventory.Inventory.aSlot = 2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CustomEventHandler.Update2(this);
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
    }
}
