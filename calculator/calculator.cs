using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float num1, num2, result=0;
            if (!float.TryParse(txtNum1.Text,out num1))
            {
                MessageBox.Show("Please enter valid number for Number 1");
                txtNum1.Focus();
                return;
            }
            if (!float.TryParse(txtNum2.Text,out num2))
            {
                MessageBox.Show("Please enter valid number for Number 2");
                txtNum2.Focus();
                return;
            }
            result = num1 + num2;
            txtResult.Text = result.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float num1, num2, result = 0;
            if(!float.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Please enter valid number for Number 1");
                txtNum1.Focus();
                return;
            }
            if (!float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter valid number for Number 2");
                txtNum2.Focus();
                return;
            }
            result = num1 - num2;
            txtResult.Text = result.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            float num1, num2, result = 0;
            if(!float.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Please enter valid number for Number 1");
                txtNum1.Focus();
                return;
            }
            if (!float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter valid number for Number 2");
                txtNum2.Focus();
                return;
            }
            result = num1 * num2;
            txtResult.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float num1, num2, result = 0;
            if(!float.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Please enter valid number for Number 1");
                txtNum1.Focus();
                return;
            }
            if (!float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter valid number for Number 2");
                txtNum2.Focus();
                return;
            }
            if(num2 == 0)
            {
                MessageBox.Show("Division by zero is not allowed");
                txtNum2.Focus();
                return;
            }
            result = num1 / num2;
            txtResult.Text = result.ToString();
        }
    }
}
