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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
            HideElements();
        }

        private void HideElements() //прячем элементы для красоты
        {
            adress.Hide();
            WriteAdress.Hide();
            label5.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // текст бокс номер карты
        {
            if (textBox1.Text.Length > 19){
                label3.Text = "Ошибка";
                b1.Enabled = false;  }
            else {
                label3.Text = "";
                b1.Enabled = true; }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Выбор способа доставки
        {

            string selected = comboBox1.SelectedItem.ToString();
            if(selected == "Самовывоз")
            {
                adress.Show();
                label5.Show();
                label5.Text = "Адрес магазина";
                adress.Text = "ул. Рокоссовского, дом 35";
            }
               
            else{
                adress.Text = "";
                label5.Text = "Напишите адрес доставки"; }
                

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //текст бокс CVC кода
        {
            if (textBox2.Text.Length > 4) {
                label6.Text = "Ошибка";
                b1.Enabled = false; }
            else {
                label6.Text = "";
                b1.Enabled = true; }

        }

        private void b1_Click(object sender, EventArgs e) // кнопка оплатить
        {
            Buy buyForm = new Buy();
            buyForm.Show();
            this.Hide();
            MessageBox.Show("Оплата совершена успешно! Спасибо уважаемый человечик");

        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
