using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASA_Calculator
{
    public partial class frmCalculator : Form
    {
        double num1, num2, result;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 - num2;
            lblSolution.Text = result.ToString();
            lblOperator.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 * num2;
            lblSolution.Text = result.ToString();
            lblOperator.Text = "*";
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 % num2;
            lblSolution.Text = result.ToString();
            lblOperator.Text = "%";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 / num2;
            lblSolution.Text = result.ToString();
            lblOperator.Text = "/";
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = Math.Pow(num1,num2);
            lblSolution.Text = result.ToString();
            lblOperator.Text = "^";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSolution.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblOperator.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 + num2;
            lblSolution.Text = result.ToString();
            lblOperator.Text = "+";
        }
    }
}
