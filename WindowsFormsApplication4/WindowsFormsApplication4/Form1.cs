using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int sayı;
        int mod;
        int kuvvet = 1;
        int sonuc=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = ""; 
            sayı = Convert.ToInt32(textBox1.Text);
            while(sayı > 6)
            
                
            {

                mod = sayı % 7;  
                sayı = sayı / 7;
                label1.Text = sayı.ToString() +" "+ label1.Text ;
                label2.Text = mod.ToString() + "  "+ label2.Text ;

            }

       
            label2.Text =  sayı.ToString() + "  "+label2.Text ;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            sayı = Convert.ToInt32(textBox1.Text);

            while (sayı >=1)
            {
                mod = sayı % 10;
                sayı = sayı / 10;
                label1.Text = sayı.ToString() + " " + label1.Text;
                label2.Text = mod.ToString() + "  " + label2.Text;
                label3.Text = kuvvet.ToString() + "  " + label3.Text;
                sonuc = sonuc + kuvvet * mod; 
                kuvvet = kuvvet * 2;
            
           }

             //label2.Text = sayı.ToString() + "  " + label2.Text;
            //label3.Text = kuvvet.ToString() + "  " + label3.Text;
            label4.Text = sonuc.ToString(); 
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
