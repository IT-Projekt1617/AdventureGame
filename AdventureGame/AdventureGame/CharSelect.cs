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
    public partial class CharSelect : Form
    {
        public static int Char = 0;
        public CharSelect()
        {
            
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Level_04 l = new Level_04();
            Char = 1;
            l.Show();
            this.Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Level_04 l = new Level_04();
            Char = 2;
            l.Show();
            this.Close();
        }
        public int getChar()
        {
            return Char;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
    }
}
