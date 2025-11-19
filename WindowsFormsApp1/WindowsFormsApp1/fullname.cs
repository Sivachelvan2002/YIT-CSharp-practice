using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fullname : Form
    {
        public fullname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("welcome to c#");
            //String name = txtName.Text;
           // MessageBox.Show($"Hi {name}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFullname_Click(object sender, EventArgs e)
        {
            String fname=txtFname.Text;
            String lname=txtLname.Text;
            
            MessageBox.Show($"Your Full Name is {fname}{lname}");
        }
    }
}
