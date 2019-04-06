using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        string tcNO;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tcNO = Convert.ToString(textBox1.Text);
                label1.Text = tcNO.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
