using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_registration
{
    public partial class Form2 : Form
    {
        string fname;
        string lname;
        string gender;
        string grade;
        List<string> subjects;
        string dob;
        string address;
        public Form2(string fname,string lname,string gender,string grade,List<string> subjects,string dob,string address)
        {
            
            InitializeComponent();
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.grade = grade;
            this.subjects = subjects;
            this.dob = dob;
            this.address = address;


            txtFname.Text = this.fname;
            txtLname.Text = this.lname;
            if(this.gender == "Male")
            {
                rdoMale.Checked = true;
            }
            else if(this.gender == "Female")
            {
                rdoFemale.Checked = true;
            }
            else
            {
                rdoOther.Checked = true;
            }
            cmbGrade.SelectedItem = this.grade;
            if(this.subjects.Contains("Maths"))
            {
                ckbMaths.Checked = true;
            }
            if(this.subjects.Contains("English"))
            {
                ckbEnglish.Checked = true;
            }
            if(this.subjects.Contains("ICT"))
            {
                ckbIct.Checked = true;
            }
            dtpDob.Value =DateTime.Parse(this.dob);
            txtAddress.Text = this.address;

        }
    }
}
