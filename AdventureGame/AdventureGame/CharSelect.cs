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
        int Char = 0;
        public CharSelect()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Level_01 l = new Level_01();
            l.Show();
            this.Close();
            Char = 1;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Level_01 l = new Level_01();
            l.Show();
            this.Close();
            Char =2 ;
        }
        public int getChar()
        {
            return Char;
        }

    }
}
