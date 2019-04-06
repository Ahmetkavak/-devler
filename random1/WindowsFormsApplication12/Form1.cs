using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int[] toplam = new int[10];
            Random salla = new Random();
            for (int k = 0; k < 10; k++)
            {
                a[k] = salla.Next(0, 100);
                b[k] = salla.Next(0, 100);
                toplam[k]=a[k]+b[k];
                A_DEĞERİ.Items.Add(a[k]);//a'yı yazdırma
                B_DEĞERİ.Items.Add(b[k]);//b'yi yazdırma
                TOPLAM.Items.Add(toplam[k]);//toplamı yazdırma
            }
        }
    }
    }

