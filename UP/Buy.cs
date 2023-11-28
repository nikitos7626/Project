using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UP
{
    public partial class Buy : Form
    {
        private Database _data = new Database();
        private DataTable _table = new DataTable();

        private SqlDataAdapter _adapter;

        private int _selectedRow;


        public Buy()
        {
            InitializeComponent();
        }


        private void Buy_Load(object sender, EventArgs e) 
        {
            _adapter = new SqlDataAdapter("SELECT * FROM books", _data.GetConnection()); 

            _adapter.Fill(_table); 
            dataGridView1.DataSource = _table; 

        }


        private void buttonBackToProfile_Click(object sender, EventArgs e)
        {
            Catatlog prof = new Catatlog();
            prof.Show();
            this.Hide();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // выбираем товар
        {
           _selectedRow = e.RowIndex;
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
        }

        private void добавитьВКорзинуToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            DataGridViewRow row = dataGridView1.Rows[_selectedRow];
            nameTovar.Items.Add(row.Cells[1].Value.ToString()); 

            int sum;
            int priceLastTovar = Convert.ToInt32(row.Cells[3].Value); 
            sum =+ priceLastTovar;
            textBox1.Text = sum.ToString();
     
        }

        private void информацияОТовареToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            DataGridViewRow row = dataGridView1.Rows[_selectedRow];
            if (infoTovar.Items.Count == 1){
                infoTovar.Clear();
                infoTovar.Items.Add(row.Cells[5].Value.ToString());
            }
            else
                infoTovar.Items.Add(row.Cells[5].Value.ToString());

        }

        private void nameTovar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right )
                contextMenuStrip2.Show(MousePosition, ToolStripDropDownDirection.Right);
        }

        private void удалитьТоварToolStripMenuItem_Click(object sender, EventArgs e) 
        {      
            if (nameTovar.Items.Count != 0 && nameTovar.SelectedItems[0].Index >= 0)
            {
                int selected = nameTovar.SelectedItems[0].Index;
                nameTovar.Items.RemoveAt(selected);              
            }

               
        }

        private void nameTovar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameTovar.Items.Count == 0)
               Zakaz.Hide();
           else
               Zakaz.Show();

        }

        private void Zakaz_Click(object sender, EventArgs e)
        {
            CartForm crt = new CartForm();
            crt.Show();
            this.Hide();
        }

    }
}
