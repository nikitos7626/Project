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
        }
    }
}
