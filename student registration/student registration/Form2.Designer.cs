namespace student_registration
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.ckbEnglish = new System.Windows.Forms.CheckBox();
            this.ckbIct = new System.Windows.Forms.CheckBox();
            this.ckbMaths = new System.Windows.Forms.CheckBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(357, 323);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 48);
            this.txtAddress.TabIndex = 40;
            // 
            // dtpDob
            // 
            this.dtpDob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Location = new System.Drawing.Point(357, 291);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(205, 22);
            this.dtpDob.TabIndex = 39;
            // 
            // ckbEnglish
            // 
            this.ckbEnglish.AutoSize = true;
            this.ckbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEnglish.Location = new System.Drawing.Point(361, 261);
            this.ckbEnglish.Name = "ckbEnglish";
            this.ckbEnglish.Size = new System.Drawing.Size(70, 20);
            this.ckbEnglish.TabIndex = 38;
            this.ckbEnglish.Text = "English";
            this.ckbEnglish.UseVisualStyleBackColor = true;
            // 
            // ckbIct
            // 
            this.ckbIct.AutoSize = true;
            this.ckbIct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIct.Location = new System.Drawing.Point(361, 235);
            this.ckbIct.Name = "ckbIct";
            this.ckbIct.Size = new System.Drawing.Size(47, 20);
            this.ckbIct.TabIndex = 37;
            this.ckbIct.Text = "ICT";
            this.ckbIct.UseVisualStyleBackColor = true;
            // 
            // ckbMaths
            // 
            this.ckbMaths.AutoSize = true;
            this.ckbMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMaths.Location = new System.Drawing.Point(361, 209);
            this.ckbMaths.Name = "ckbMaths";
            this.ckbMaths.Size = new System.Drawing.Size(62, 20);
            this.ckbMaths.TabIndex = 36;
            this.ckbMaths.Text = "Maths";
            this.ckbMaths.UseVisualStyleBackColor = true;
            // 
            // cmbGrade
            // 
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "Grade 10",
            "Grade 11",
            "Grade 12"});
            this.cmbGrade.Location = new System.Drawing.Point(357, 175);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(205, 24);
            this.cmbGrade.TabIndex = 35;
            this.cmbGrade.Text = "-- select grade --";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOther.Location = new System.Drawing.Point(493, 147);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(57, 20);
            this.rdoOther.TabIndex = 34;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(418, 147);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(71, 20);
            this.rdoFemale.TabIndex = 33;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(357, 146);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(55, 20);
            this.rdoMale.TabIndex = 32;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(357, 111);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(205, 20);
            this.txtLname.TabIndex = 31;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(357, 79);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(205, 20);
            this.txtFname.TabIndex = 30;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(251, 213);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 16);
            this.lblSubject.TabIndex = 29;
            this.lblSubject.Text = "Subjects";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(372, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btnBack.Size = new System.Drawing.Size(58, 20);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(251, 329);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(251, 297);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(36, 16);
            this.lbldob.TabIndex = 26;
            this.lbldob.Text = "DOB";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(251, 181);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(45, 16);
            this.lblGrade.TabIndex = 25;
            this.lblGrade.Text = "Grade";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(251, 149);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(251, 115);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(72, 16);
            this.lblLname.TabIndex = 23;
            this.lblLname.Text = "Last Name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(251, 84);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(72, 16);
            this.lblFname.TabIndex = 22;
            this.lblFname.Text = "First Name";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(199, 23);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(150, 10, 150, 10);
            this.lblHeading.Size = new System.Drawing.Size(471, 40);
            this.lblHeading.TabIndex = 21;
            this.lblHeading.Text = "Edit Student Details";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.ckbEnglish);
            this.Controls.Add(this.ckbIct);
            this.Controls.Add(this.ckbMaths);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.CheckBox ckbEnglish;
        private System.Windows.Forms.CheckBox ckbIct;
        private System.Windows.Forms.CheckBox ckbMaths;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblHeading;
    }
}