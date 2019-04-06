using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        int toplam = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ust;
            toplam = 0;

            ust = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= ust; i++)
            {
                toplam = toplam + i;

            }
            label1.Text = toplam.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            int mod;
            mod = sayi % 2;
            if (mod == 0)
            {
                sayi = sayi - 1;

            }
            int ust;
            ust = (sayi + 1) / 2;
            for (int i = 0; i <= ust; i++)
            {
                toplam = toplam + (2 * i - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
