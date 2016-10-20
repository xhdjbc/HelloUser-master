using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUser
{
    public partial class frmHelloUser : Form
    {

        public frmHelloUser()
        {
            InitializeComponent();
            
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            /**
             *
             * Name: ZiChao Liu
             * 
             * Teacher: Mr. Hardman
             * 
             * Assignment #2, Program #1
             * 
             * Date Last Modified: 10/19/2016
             * 
             */


            //using user input
            double input1 = Convert.ToDouble(txtOutput1.Text);
            double input2 = Convert.ToDouble(txtOutput2.Text);


            double total = input1 / input2 * 100;

            //computer display
            lblDisplay.Text = string.Format("{0,4}{1,29:C2}\n{2,10}{3,23:g0}\n{4,2}{5,29:C2}", "Taxes", input1, "Tax rate(%)", input2, "Price", total);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmHelloUser_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
