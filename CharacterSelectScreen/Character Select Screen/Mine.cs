using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Select_Screen
{
    public partial class Mine : Form
    {
        int minerals = 0;
        bool AlreadyMined;
        Village village;
        public Mine(Village v)
        {
            village = v;
            InitializeComponent();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            if (AlreadyMined)
            {
                MessageBox.Show("You Mined Already");
            }
            else
            {
                AlreadyMined = true;
                minerals = 0;
                if (checkBox1.Checked)
                    minerals += 1;
                if (checkBox2.Checked)
                    minerals += 1;
                if (checkBox3.Checked)
                    minerals += 1;
                if (checkBox4.Checked)
                    minerals += 1;
                if (checkBox5.Checked)
                    minerals += 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AlreadyMined = false;
            this.Hide();
            village.Show();
            village.finishMine(minerals);
        }
    }
}
