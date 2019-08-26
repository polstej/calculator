using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var calculator = new Calculator();
            lblAnswer.Text=  Convert.ToString(calculator.Add(txtFirstNumber.Text, txtSecondNumber.Text));
            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

            var calculator = new Calculator();
            lblAnswer.Text = Convert.ToString(calculator.Subtract(txtFirstNumber.Text, txtSecondNumber.Text));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            var calculator = new Calculator();
            lblAnswer.Text = Convert.ToString(calculator.Multiply(txtFirstNumber.Text, txtSecondNumber.Text));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            var calculator = new Calculator();
            lblAnswer.Text = Convert.ToString(calculator.Divide(txtFirstNumber.Text, txtSecondNumber.Text));
        }
    }
}
