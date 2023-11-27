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
namespace UP
{
  
    public partial class addform : Form
    {
        Database database = new Database();
        public addform()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenConnection();
            var name = textBox_name.Text;
            var discount = textBox_discount.Text;
            var opisanie = textBox_opisanie.Text;
            var proizvoditel = textBox_proizvoditel.Text;
            int price;
            if (int.TryParse(textBox_price.Text,out price))
            {
                var addQuery = $"insert into books(name_book,price,discount,opisanie,proizvoditel) values ('{name}','{price}','{discount}','{opisanie}','{proizvoditel}')";
                var command = new SqlCommand(addQuery,database.GetConnection());
                command.ExecuteNonQuery();  
                MessageBox.Show("Запись успешно создана!!","Успех!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!","ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning); //ророрн
            }
            database.CloseConnection();
        }

        private void addform_Load(object sender, EventArgs e)
        {

        }
    }
}
