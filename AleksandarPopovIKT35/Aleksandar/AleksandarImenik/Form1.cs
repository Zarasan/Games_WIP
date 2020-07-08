using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AleksandarImenik
{
    public partial class Form1 : Form
    {
        private Detali detali;
        ImenikDataContext context;
        public Form1()
        {
            InitializeComponent();
            context = new ImenikDataContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imenikBindingSource.DataSource = from imenik in context.Imeniks
                                             orderby imenik.Id
                                             select imenik;
        }

        private void imenikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            imenikBindingSource.EndEdit();
            context.SubmitChanges();

        }

        private void prebaruvajTxt_TextChanged(object sender, EventArgs e)
        {
            imenikBindingSource.DataSource = from imenik in context.Imeniks
                                             where imenik.Ime.StartsWith(prebaruvajTxt.Text)
                                             orderby imenik.Id
                                             select imenik;
        }

        private void imenikDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String ime = imenikDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                String prezime = imenikDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                String grad = imenikDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                String broj = imenikDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                detali = new Detali(ime, prezime, grad, broj);
                detali.Show();
            }
        }
    }
}
