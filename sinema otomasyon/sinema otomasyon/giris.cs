using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadı,sifre;
            kullaniciadı = textBox1.Text;
            sifre = textBox2.Text;
            if (kullaniciadı == "admin" && sifre == "12345")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
            else {

                label3.ForeColor = Color.Red;
                label3.Text = "Kullanıcı Bulunmamaktadır.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "KullanıcıAdı:admin Şifre:12345";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
