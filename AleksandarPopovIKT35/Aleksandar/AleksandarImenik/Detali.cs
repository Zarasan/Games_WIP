using System;
using System.Windows.Forms;

namespace AleksandarImenik
{
    public partial class Detali : Form
    {
        public Detali()
        {
            InitializeComponent();
        }

        public Detali(String Ime = "", String Prezime = "", String Grad = "", String Broj = "")
        {
            InitializeComponent();
            label2.Text = Ime;
            label4.Text = Prezime;
            label6.Text = Grad;
            label8.Text = Broj;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
