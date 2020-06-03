using Character_Select_Screen.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Select_Screen
{
    public partial class Village : Form
    {
        Mine m;
        Fields f;
        public Player User { get; set; }
        public Village(Player p)
        {
            User = p;
            InitializeComponent();
            UpdateStats();
            m = new Mine(this);
            f = new Fields(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            User.Save();
        }

        public void ReturnToVillage()
        {
            UpdateStats();
        }

        private void UpdateStats()
        {
            User.Level = User.Xp / 100;
            label1.Text = User.Name.ToString();
            label5.Text = User.Gender.ToString();
            label6.Text = User.Profession.ToString();
            label4.Text = User.Cash.ToString();
            label3.Text = User.Level.ToString();
            progressBar1.Value = User.Xp % 100;
            pictureBox2.ImageLocation = User.Avatar.ToString();
            checkWin();
        }

        private void checkWin()
        {
            if(User.Cash > 750)
            {
                MessageBox.Show("You Won. You are now rich!!!");
                this.Close();
                Application.Exit();
            }
        }
        public void finishMine(int mat)
        {
            int mul = 10;
            if (User.Profession == "Miner")
                mul = 20;
            User.Xp += mat * mul * User.Level;
            User.Cash += mat * mul * User.Level / 2;
            UpdateStats();
        }

        public void finishFields(int mat)
        {
            int mul = 10;
            if (User.Profession == "Herbalist")
                mul = 20;
            User.Xp += mat * mul * User.Level;
            User.Cash += mat * mul * User.Level / 10;
            UpdateStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Hide();
        }
    }
}
