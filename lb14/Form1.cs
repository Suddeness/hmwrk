using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double? tryD(string val) 
        {
            if (double.TryParse(val, out double result)) 
            {
                return result;
            }
            else 
            {
                return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double? xmn = tryD(xmin.Text);
            double? xmx = tryD(xmax.Text);
            double? xdx = tryD(dx.Text);

            if (xmn != null && xmx != null && xdx != null && xdx != 0)
            {
                Dictionary<double, string> results = Calculate.CalculateF(xmn, xmx, xdx);               
                foreach (double x in results.Keys)
                {   
                    listBox1.Items.Add($"for x = {x.ToString()}: z = {results[x]}");
                }
            }
            else { listBox1.Items.Add("Error incorrect data"); }
        }     
    }
}
