using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string fname;
            string lname;
            string gender;
            string grade;
            string dob;
            string address;

            //first name validation
            if (string.IsNullOrEmpty(txtFname.Text.Trim()))
            {
                MessageBox.Show("please fill first name");
                txtFname.Focus();
                return;
            }
            //last name validation
            if (string.IsNullOrEmpty(txtLname.Text.Trim()))
            {
                MessageBox.Show("please fill last name");
                txtLname.Focus();
                return;
            }
            //assign values for fname,lname
            fname = txtFname.Text;
            lname = txtLname.Text;

            //gender validation
            if (!rdoMale.Checked && !rdoFemale.Checked && !rdoOther.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }
            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else if (rdoFemale.Checked)
            {
                gender = "Female";
            }
            else if (rdoOther.Checked)
            {
                gender = "Other";
            }
            else
            {
                gender = "Male";
            }
            if (cmbGrade.SelectedItem == null)
            {
                MessageBox.Show("Please select a grade.");
                cmbGrade.Focus();
                return;
            }
            grade = cmbGrade.SelectedItem.ToString();
            if(!ckbMaths.Checked && !ckbIct.Checked && !ckbEnglish.Checked)
            {
                MessageBox.Show("please select subjects");
                return;
            }
            List<string> subjects = new List<string>();
            if(ckbMaths.Checked)
            {
                subjects.Add("Maths");
            }
            if(ckbEnglish.Checked) {
                subjects.Add("English");
            }
            if(ckbIct.Checked)
            {
                subjects.Add("ICT");
            }
            if (dtpDob.Value > DateTime.Today)
            {
                MessageBox.Show("dob cannot be future date");
                dtpDob.Focus();
                return;
            }
            dob = dtpDob.Value.ToShortDateString();
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("please fill the address");
                txtAddress.Focus();
                return;
            }
           
            
            address = txtAddress.Text;

            Form2 f2 = new Form2(fname,lname,gender,grade,subjects,dob,address);
            f2.Show();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;
            cmbGrade.SelectedIndex = -1;
            ckbMaths.Checked = false;
            ckbEnglish.Checked = false;
            ckbIct.Checked = false;
            dtpDob.Value = DateTime.Today;
            txtAddress.Clear();
        }
    }
}
