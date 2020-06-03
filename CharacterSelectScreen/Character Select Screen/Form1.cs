using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Select_Screen
{
    public partial class Form1 : Form
    {
        int gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                gender = 1;
                pictureBox1.Image = Properties.Resources.male_lumberjack;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                gender = 2;
                pictureBox1.Image = Properties.Resources.female_lumberjack;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            switch (cb.SelectedItem)
            {
                case "Lumberjack":
                    if (gender == 1)
                    {
                        pictureBox1.Image = Properties.Resources.male_lumberjack;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.female_lumberjack;
                    }
                break;
                case "Miner":
                    if (gender == 1)
                    {
                        pictureBox1.Image = Properties.Resources.male_lumberjack;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.female_Miner;
                    }
                    break;
                case "Herbalist":
                    if (gender == 1)
                    {
                        pictureBox1.Image = Properties.Resources.male_lumberjack;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.female_Herbalist;
                    }
                    break;
            }

        }
    }
}
