using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X + 5, 108);
            if (button1.Location.X == 215)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X - 5, 108);
            if (button1.Location.X == 0)
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            //timer1 kod
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
