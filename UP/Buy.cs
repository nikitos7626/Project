using System;
using System.Collections.Generic;
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
         //   hideZakaz();
        }


        private void Buy_Load(object sender, EventArgs e) // Загрузка формы 
        {
            _adapter = new SqlDataAdapter("SELECT * FROM books", _data.GetConnection()); // Запрос для выборки данных

            _adapter.Fill(_table); // заполняем таблицы с помощью адаптера
            dataGridView1.DataSource = _table; // Данные в гриде

        }


        private void buttonBackToProfile_Click(object sender, EventArgs e)
        {
            Catatlog prof = new Catatlog();
            prof.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




           // string nameTovar = textBox1.Text;     
          //  APP.SetKorzina(nameTovar);
           // listView1.Items.Add(APP.GetKorzina().ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // выбираем товар
        {
           _selectedRow = e.RowIndex;
         //   if (e.RowIndex >= 0) 
          //  {
          //      DataGridViewRow row = dataGridView1.Rows[_selectedRow];
          //      nameTovar.Items.Add(row.Cells[1].Value.ToString()); // вывод названия
          //      nameTovar.Items.Add(row.Cells[3].Value.ToString()); // вывод цены
          //  }

            //  DataGridViewRow rowInfo = dataGridView1.Rows[SelectedRow]; // полученная строка(вся инф о товаре) для записи в APP лист
         //   int _index = dataGridView1.Rows[SelectedRow].Index;
         //   APP.SetIndex(_index);


           // names.Add(rowInfo.ToString());
           // APP.SetKorzina(names);

           // InfoTovar.Items.Add(APP.GetKorzina());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
        }

        private void добавитьВКорзинуToolStripMenuItem_Click(object sender, EventArgs e) // Добавляем товар в корзину
        {
            DataGridViewRow row = dataGridView1.Rows[_selectedRow];
            nameTovar.Items.Add(row.Cells[1].Value.ToString()); // вывод названия

            int sum;
            int priceLastTovar = Convert.ToInt32(row.Cells[3].Value); // цена
            sum =+ priceLastTovar;
            textBox1.Text = sum.ToString();
     
        }

        private void информацияОТовареToolStripMenuItem_Click(object sender, EventArgs e) // Вывод информации
        {
            DataGridViewRow row = dataGridView1.Rows[_selectedRow];
            if (infoTovar.Items.Count == 1){
                infoTovar.Clear();
                infoTovar.Items.Add(row.Cells[5].Value.ToString());
            }
            else
                infoTovar.Items.Add(row.Cells[5].Value.ToString());

        }

     //   private void hideZakaz()
    //    {
     //       if (nameTovar.Items.Count == 0)
    //            Zakaz.Hide();
    //        else
    //            Zakaz.Show();
    //    }

        private void nameTovar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right )
                contextMenuStrip2.Show(MousePosition, ToolStripDropDownDirection.Right);
        }

        private void удалитьТоварToolStripMenuItem_Click(object sender, EventArgs e) // контекс меню - удалить товар
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
// ценник, название храним в листе