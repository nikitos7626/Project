using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UP
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private Boolean chekuser()
        {
            Database database = new Database();
            var loginuser = textBox1.Text;
            var passwordUser = textBox2.Text;
            var name = textBox4.Text;
            var phoneNumber = textBox3.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string zapros = $"select name,phone_numer,login,password where '{name}' = name, '{phoneNumber}'=phone_number, '{passwordUser}'=password, '{loginuser}'=login";
            SqlCommand command = new SqlCommand(zapros, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
                return false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            var loginUser = textBox1.Text;
            var passwordUser = textBox2.Text;
            var name = textBox4.Text;
            var phoneNumber = textBox3.Text;

            database.OpenConnection();
            string registr = $"insert into Client (name,phone_number,login,password) values ('{name}', '{phoneNumber}','{loginUser}','{passwordUser}')";

            SqlCommand command = new SqlCommand(registr, database.GetConnection());

            if (checkBox1.Checked)
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успех!");

                    Form1 frm1 = new Form1();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                    this.Close();
                }             
            }
            else
                label7.Text = "Вы не человек";
            database.CloseConnection();
        }
    }
}
