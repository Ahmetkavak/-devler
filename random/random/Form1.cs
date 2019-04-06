using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int a;
        private void button1_Click(object sender, EventArgs e)
        {

            Random üret = new Random();
            a = üret.Next(101);
            sayi = 100;
            label2.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            sayi = sayi + (sayi / 2);
            label2.Text = sayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi = sayi - (sayi / 2);
            label2.Text = sayi.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = " ";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
