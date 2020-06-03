using Character_Select_Screen.Classes;
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
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Character_Select_Screen
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name == "")
            {
                MessageBox.Show("You need a name bud.");
            }
            else
            {
                string prof = "";
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Get a job.");
                }
                else
                {
                    prof = comboBox1.SelectedItem.ToString();
                    string gender = "";
                    if (radioButton1.Checked)
                    {
                        gender = "Male";
                    }
                    else if (radioButton2.Checked)
                    {
                        gender = "Female";
                    }
                    string avatar = pictureBox1.ImageLocation;
                    if (avatar == null)
                    {
                        MessageBox.Show("You must have face.");
                    }
                    else
                    {
                        Player p = new Player(name, gender, prof, 0, 100, 1, avatar);
                        p.Save();
                        string createChar = File.ReadAllText("player.xml");
                        Console.WriteLine(createChar);
                        ChangeLevel(p);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "";
            string gender = "";
            string profession = "";
            int money = 0;
            int xp = 0;
            int lvl = 0;
            string avatar = "";

            string current = "";
            XmlTextReader reader = new XmlTextReader("player.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        current = reader.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (current)
                        {
                            case "Name":
                                textBox1.Text = reader.Value;
                                name = reader.Value;
                                break;
                            case "Gender":
                                if (reader.Value == "Female")
                                    radioButton2.Checked = true;
                                gender = reader.Value;
                                break;
                            case "Profession":
                                comboBox1.SelectedItem = reader.Value;
                                profession = reader.Value;
                                break;
                            case "Money":
                                money = Int32.Parse(reader.Value);
                                break;
                            case "Experience":
                                xp = Int32.Parse(reader.Value);
                                break;
                            case "Level":
                                lvl = Int32.Parse(reader.Value);
                                break;
                            case "Avatar":
                                avatar = reader.Value;
                                break;
                        }
                        break;
                }
            }
            Player p = new Player(name, gender, profession, money, xp, lvl, avatar);
            ChangeLevel(p);
        }

        private void ChangeLevel(Player p)
        {
            Village village = new Village(p);
            village.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                    Console.WriteLine("raboti");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
