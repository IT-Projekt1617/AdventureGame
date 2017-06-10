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


namespace AdventureGame
{
    public partial class Level_01 : Form
    {
        
        Player p;
        public Level_01()
        {
            InitializeComponent();

            p = new Player(player, 10, 20, 20, 0, null);
            Barrier.addBarrier(barrier1);
            Barrier.addBarrier(barrier2);
               
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
            CustomEventHandler.KeyUp(panel1,e, p);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CustomEventHandler.PaintEvent(panel1,e,p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = "Leben: "+p.getHealth()+"/"+p.getmaxHealth();
            CustomEventHandler.Update(panel1,e,p);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void Level_01_Load(object sender, EventArgs e)
        {

            Item testitem = new Item("Test",Properties.Resources.item__1_);
            testitem.drop(100,30,this);
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
            if (Inventory.Inventory.s1 != null)
            {
                Inventory.Inventory.ps1.Image = Inventory.Inventory.s1.getTexturepath();

            }
            else
            {
                Inventory.Inventory.ps1.Image = null;
            }
            if (Inventory.Inventory.s2 != null)
            {
                Inventory.Inventory.ps2.Image = Inventory.Inventory.s2.getTexturepath();

            }
            else
            {
                Inventory.Inventory.ps2.Image = null;
            }
            if (Inventory.Inventory.s3 != null)
            {
                Inventory.Inventory.ps3.Image = Inventory.Inventory.s3.getTexturepath();

            }
            else
            {
                Inventory.Inventory.ps3.Image = null;
            }

        }

        private void Slot1_Click(object sender, EventArgs e)
        {
            Inventory.Inventory.aSlot = 1;
        }

        private void Slot3_Click(object sender, EventArgs e)
        {
            Inventory.Inventory.aSlot = 3;

        }
    }
}
