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
    public partial class hasılat : Form
    {
        public hasılat()
        {
            InitializeComponent();
        }
       
        private void hasılat_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = " Günlük Hasılat ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = label2.Text.Substring(1) + label2.Text.Substring(0, 1);
        }
    }
}
