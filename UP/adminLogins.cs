using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP
{
    public partial class adminLogins : Form
    {
        Database database = new Database();
        public adminLogins()
        {
            InitializeComponent();
        }

        private void adminLogins_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var PasswordUser = textBox2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id,login,password from admin where login = '{loginUser}' and password = '{PasswordUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
