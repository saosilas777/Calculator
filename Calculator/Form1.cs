using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        Calc c = new Calc();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Valor = double.Parse(textBox1.Text); 
            
            double result = c.desc1();
            label5.Text = result.ToString("F2", CultureInfo.InvariantCulture);
            c.Valor = double.Parse(textBox1.Text);
            result = c.desc2();           
            label6.Text = result.ToString("F2", CultureInfo.InvariantCulture);
            c.Valor = double.Parse(textBox1.Text);
            result = c.desc3();
            label7.Text = result.ToString("F2", CultureInfo.InvariantCulture);
            


        }
        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
