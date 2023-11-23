using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace UP
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        Deleted,
        ModifiedNew
    }
    public partial class Form2 : Form
    {
        Database database = new Database();
        int selectedRow;
        public Form2()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
           dataGridView1.Columns.Add("ProductId","ProductId");
           dataGridView1.Columns.Add("name_book", "Название книги");
            dataGridView1.Columns.Add("price", "цена");
            dataGridView1.Columns.Add("discount", "скидка");
            dataGridView1.Columns.Add("opisanie", "описание");
            dataGridView1.Columns.Add("proizvoditel", "производитель");
            dataGridView1.Columns.Add("IsNew",string.Empty);  
        }

        private void ReadSingleRow(DataGridView dgw,IDataRecord record) 
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetInt32(2),record.GetInt32(3),record.GetString(4),record.GetString(5),RowState.ModifiedNew);

        }
        private void RefreshDataGried(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from books";
            SqlCommand command = new SqlCommand(queryString,database.GetConnection());

            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGried(dataGridView1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
