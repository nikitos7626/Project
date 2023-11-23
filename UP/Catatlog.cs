using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP
{
    public partial class Catatlog : Form
    {
        public Catatlog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBalance_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(labelBalance.Text);

            balance += Convert.ToInt32(textBoxAddBalance.Text);

            labelBalance.Text = balance.ToString();
            textBoxAddBalance.Clear();

            String connection = "Database=boop;ACER\\SQLEXPRESS;User Id=Kira;Password=" + labelBalance.Text; // сдесь мейби неправильно если что выебываеться смотри сюда !
        }

        private void Catatlog_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Buy b = new Buy();
            b.Show();
            this.Hide();
        }
    }
}
