using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Select_Screen
{
    public partial class Fields : Form
    {
        bool AlreadyHarvested = false;
        int harvest = 0;
        Village village;
        public Fields(Village v)
        {
            village = v;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlreadyHarvested = false;
            this.Hide();
            village.finishFields(harvest);
            village.Show();
        }
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            if (AlreadyHarvested)
            {
                MessageBox.Show("Crops are harvested!");
            }
            else
            {
                AlreadyHarvested = true;
                int chance = rand.Next(0, 100);
                switch (textBox1.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
                switch (textBox2.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
                switch (textBox3.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
                switch (textBox4.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
                switch (textBox5.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
                switch (textBox6.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
                switch (textBox7.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
                switch (textBox8.Text)
                {
                    case "Carrots":
                        if (chance > 60)
                            harvest += 6;
                        break;
                    case "Pumpkins":
                        if (chance > 30)
                            harvest += 15;
                        break;
                    case "Corn":
                        if (chance > 70)
                            harvest += 3;
                        break;
                }
            }
        }
    }
}
