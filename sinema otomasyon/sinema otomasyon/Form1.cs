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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1kisi = 0;
        int seans1ücret = 0;
        int seans2kisi = 0;
        int seans2ücret = 0;
        int seans3ücret = 0;
        int seans3kisi = 0;
        int kisimısır = 0;
        int kisikola = 0;
        int kisisu = 0;
        int mısırücret = 0;
        int kolaücret = 0;
        int suücret = 0;
        int toplamhasılat;
        private void button2_Click(object sender, EventArgs e)
        {
            seans1kisi--;
            seans1ücret -= 10;
            toplamhasılat -= 10;
            textBox1.Text = seans1kisi.ToString();
            textBox2.Text = seans1ücret.ToString();
            if (seans1kisi < 10)
            {
                button1.Enabled = true;
            }
            if (seans1kisi <= 0)
            {
                seans1kisi = 0;
                seans1ücret = 0;
                textBox1.Text = seans1kisi.ToString();
                textBox2.Text = seans1ücret.ToString();
                button2.Enabled = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            seans1kisi++;
            seans1ücret += 10;
            toplamhasılat += 10;
            textBox1.Text = seans1kisi.ToString();
            textBox2.Text = seans1ücret.ToString();
            if (seans1kisi== 10)
            {
                button1.Enabled = false;
            }
            if (seans1kisi > 0)
            {
                button2.Enabled = true;
            }
            
            }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2kisi++;
            seans2ücret += 10;
            toplamhasılat += 10;
            textBox4.Text = seans2kisi.ToString();
            textBox3.Text = seans2ücret.ToString();
            if (seans2kisi == 10)
            {
                button3.Enabled = false;
            
            }
            if (seans2kisi > 0)
            {
               
                button4.Enabled = true;


            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2kisi--;
            seans2ücret -= 10;
            toplamhasılat -= 10;
            textBox4.Text = seans2kisi.ToString();
            textBox3.Text = seans2ücret.ToString();
            if (seans2kisi < 10)
            {
                button3.Enabled = true;
            
            }
              if (seans2kisi <= 0)
            {
                seans2kisi = 0;
                seans2ücret = 0;
                textBox4.Text = seans2kisi.ToString();
                textBox3.Text = seans2ücret.ToString();
                button4.Enabled = false;

            
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3kisi++;
            seans3ücret += 10;
            toplamhasılat += 10;
            textBox6.Text = seans3kisi.ToString();
            textBox5.Text = seans3ücret.ToString();
            if (seans3kisi == 10)
            {
                button5.Enabled = false;
            
            }
            if (seans3kisi > 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3kisi--;
            seans3ücret -= 10;
            toplamhasılat -= 10;
            textBox6.Text = seans3kisi.ToString();
            textBox5.Text = seans3ücret.ToString();
            if (seans3kisi == 10)
            {
                button5.Enabled = true;
            }
            if (seans3kisi <= 0)
            {
                seans3kisi = 0;
                seans3ücret = 0;
                textBox6.Text = seans3kisi.ToString();
                textBox5.Text = seans3ücret.ToString();
                button6.Enabled = false;
            
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
           int toplamücret = seans1ücret + seans2ücret + seans3ücret;
            label4.Text = toplamücret.ToString();
            int toplamseyirci = seans1kisi + seans2kisi + seans3kisi;
            label3.Text = toplamseyirci.ToString();
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            mısırücret += 5;
            kisimısır++;
            toplamhasılat += 5;
            textBox8.Text = kisimısır.ToString();
            textBox7.Text = mısırücret.ToString();

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mısırücret -= 5;
            kisimısır--;
            toplamhasılat -= 5;
            textBox8.Text = kisimısır.ToString();
            textBox7.Text = mısırücret.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kolaücret += 3;
            kisikola++;
            toplamhasılat += 3;
            textBox9.Text = kisikola.ToString();
            textBox10.Text = kolaücret.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            kolaücret -= 3;
            kisikola++;
            toplamhasılat -= 3;
            textBox9.Text = kisikola.ToString();
            textBox10.Text = kolaücret.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            suücret += 1;
            kisisu++;
            toplamhasılat += 1;
            textBox11.Text = kisisu.ToString();
            textBox12.Text = suücret.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            suücret -= 1;
            kisisu--;
            toplamhasılat -= 1;
            textBox11.Text = kisisu.ToString();
            textBox12.Text = suücret.ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string filmadı = textBox13.Text;
            label20.Text = filmadı.ToUpper();
            textBox13.Visible = false;
            button15.Visible = false;
            label19.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            button15.Visible = true;
            textBox13.Visible = true;
            seans1kisi = 0;
            seans1ücret = 0;
            seans2kisi = 0;
            seans2ücret = 0;
            seans3kisi = 0;
            seans3ücret = 0;
            kisisu = 0;
            kisimısır = 0;
            kisikola = 0;
            mısırücret = 0;
            kolaücret = 0;
            suücret = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label3.Text = "0";
            label4.Text = "0";
            label22.Text = "0";
            label21.Text = "0";
            label20.Text = "FİLM İSMİ";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            hasılat hasılat = new hasılat();
            hasılat.Show();
            hasılat.label1.Text = toplamhasılat.ToString(); ;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int toplamücret = suücret + mısırücret + kolaücret;
            label22.Text = toplamücret.ToString();
            int toplamürünkisi = kisikola + kisimısır + kisisu;
            label21.Text = toplamürünkisi.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            seans1kisi = 0;
            seans1ücret = 0;
            seans2kisi = 0;
            seans2ücret = 0;
            seans3kisi = 0;
            seans3ücret = 0;
            kisisu = 0;
            kisimısır = 0;
            kisikola = 0;
            mısırücret = 0;
            kolaücret = 0;
            suücret = 0;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
