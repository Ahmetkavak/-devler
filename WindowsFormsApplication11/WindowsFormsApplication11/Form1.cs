using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 5, 7, 9, 7, 4, 5, 1, 6, 9, 7 };
            int[] toplam = new int[10]; 
            for (int i = 0; i <10 ; i++)
            {
                toplam[i]= a[i] + b[i];
                listBox1.Items.Add(a[i]);//a'yı yazdırma
                listBox2.Items.Add(b[i]);//b'yi yazdırma
                listBox3.Items.Add(toplam[i]);//toplamı yazdırma
            
            }
            
            
            
            
            
            
            
            
            //label2.Text = (a[1] + b[1]).ToString();
            //label3.Text = (a[2] + b[2]).ToString();
            //label4.Text = (a[3] + b[3]).ToString();
            

        }
    }
}
