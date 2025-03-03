using System;
using System.Windows.Forms;

namespace Draw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        private void btn_cnfrm_Click(object sender, EventArgs e)
        {
            if (NR1.Checked)
            {
                Chicken.Checked = true;
                worker2.Checked = true;
                worker3.Checked = true;
                worker4.Checked = false;
                worker5.Checked = false;
                txt_bx.Text = "price 8000$ for one day";
            }
            else if (NR2.Checked) 
            {
                Chicken.Checked = false;
                worker2.Checked = false;
                worker3.Checked = false;
                worker4.Checked = true;
                worker5.Checked = true;
                txt_bx.Text = "price 5000$ for one day";
            }
            else if (NR3.Checked)
            {
                Chicken.Checked = true;
                worker2.Checked = true;
                worker3.Checked = true;
                worker4.Checked = true;
                worker5.Checked = true;
                txt_bx.Text = "price 10000$ for one day";
            }
            else { txt_bx.Text = "no work, no pay"; }
        }
    }
}
