using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//*********Palak Arora - 301112908 **************

namespace Palak_Arora_Exercise02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // retrieve user input
            decimal principal = decimal.Parse(principalTextBox.Text);
            double rate = double.Parse(interestTextBox.Text);
            int year = (int)yearUpDown.Value;

            // set output header
            string output = "Year\tAmount on Deposit\r\n";

            // calculate amount after each year and append to output
            for (int yearCounter = 1; yearCounter <= year; ++yearCounter)
            {
                decimal amount = principal *
                  ((decimal)Math.Pow((1 + rate / 100), yearCounter));
                output += $"{yearCounter}\t{amount:C}\r\n";
            }

            displayTextBox.Text = output; // display result
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private async void btnCalculateFact_Click(object sender, EventArgs e)
        {
            //use of BigInteger to calculate factorial of bigger numbers.
            BigInteger n = new BigInteger(int.Parse(txtFact.Text));
            BigInteger fact = new BigInteger(1);
            txtAnswer.Text = "calculating";
            await Task.Run(() => {   
                Thread.Sleep(1000);
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
            });
            txtAnswer.Text = fact.ToString();
        }
       
        private void interestLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
