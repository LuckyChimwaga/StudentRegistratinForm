namespace StudentRegistratinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.regNoLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dob_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.personalDetailsGb = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.selectCourselLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studyLevelLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.session_checkBox = new System.Windows.Forms.CheckBox();
            this.sesionLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.courselDetailsGb = new System.Windows.Forms.GroupBox();
            this.studyIntakeLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.personalDetailsGb.SuspendLayout();
            this.courselDetailsGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Here";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(180, 33);
            this.fNameTextBox.Multiline = true;
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(181, 30);
            this.fNameTextBox.TabIndex = 1;
            this.fNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(575, 397);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(91, 41);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.Register_Click);
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(15, 40);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(124, 18);
            this.fNameLabel.TabIndex = 4;
            this.fNameLabel.Text = "Enter First Name:";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(16, 80);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(127, 18);
            this.lNameLabel.TabIndex = 5;
            this.lNameLabel.Text = "Enter Last Name :";
            this.lNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(180, 136);
            this.regNoTextBox.Multiline = true;
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(181, 28);
            this.regNoTextBox.TabIndex = 7;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(180, 81);
            this.lNameTextBox.Multiline = true;
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(181, 29);
            this.lNameTextBox.TabIndex = 8;
            // 
            // regNoLabel
            // 
            this.regNoLabel.AutoSize = true;
            this.regNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoLabel.Location = new System.Drawing.Point(16, 136);
            this.regNoLabel.Name = "regNoLabel";
            this.regNoLabel.Size = new System.Drawing.Size(106, 18);
            this.regNoLabel.TabIndex = 9;
            this.regNoLabel.Text = "Enter Reg No :";
            this.regNoLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(15, 231);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(65, 18);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Gender :";
            this.genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Location = new System.Drawing.Point(180, 228);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(61, 24);
            this.male_radioButton.TabIndex = 11;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            this.male_radioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(287, 228);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(80, 24);
            this.female_radioButton.TabIndex = 12;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(15, 186);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(94, 18);
            this.dobLabel.TabIndex = 14;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // dob_dateTimePicker
            // 
            this.dob_dateTimePicker.Location = new System.Drawing.Point(180, 184);
            this.dob_dateTimePicker.Name = "dob_dateTimePicker";
            this.dob_dateTimePicker.Size = new System.Drawing.Size(181, 26);
            this.dob_dateTimePicker.TabIndex = 15;
            this.dob_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // personalDetailsGb
            // 
            this.personalDetailsGb.Controls.Add(this.fNameLabel);
            this.personalDetailsGb.Controls.Add(this.lNameLabel);
            this.personalDetailsGb.Controls.Add(this.regNoLabel);
            this.personalDetailsGb.Controls.Add(this.session_checkBox);
            this.personalDetailsGb.Controls.Add(this.female_radioButton);
            this.personalDetailsGb.Controls.Add(this.dob_dateTimePicker);
            this.personalDetailsGb.Controls.Add(this.male_radioButton);
            this.personalDetailsGb.Controls.Add(this.dobLabel);
            this.personalDetailsGb.Controls.Add(this.sesionLabel);
            this.personalDetailsGb.Controls.Add(this.genderLabel);
            this.personalDetailsGb.Controls.Add(this.regNoTextBox);
            this.personalDetailsGb.Controls.Add(this.lNameTextBox);
            this.personalDetailsGb.Controls.Add(this.fNameTextBox);
            this.personalDetailsGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalDetailsGb.Location = new System.Drawing.Point(22, 45);
            this.personalDetailsGb.Name = "personalDetailsGb";
            this.personalDetailsGb.Size = new System.Drawing.Size(375, 333);
            this.personalDetailsGb.TabIndex = 18;
            this.personalDetailsGb.TabStop = false;
            this.personalDetailsGb.Text = "Personal Details";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Tomato;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(439, 397);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 41);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // selectCourselLabel
            // 
            this.selectCourselLabel.AutoSize = true;
            this.selectCourselLabel.Location = new System.Drawing.Point(6, 112);
            this.selectCourselLabel.Name = "selectCourselLabel";
            this.selectCourselLabel.Size = new System.Drawing.Size(109, 20);
            this.selectCourselLabel.TabIndex = 17;
            this.selectCourselLabel.Text = "Select Course";
            this.selectCourselLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Computer Science",
            "Information Technology",
            "Information Communication Technology",
            "Business Management"});
            this.comboBox1.Location = new System.Drawing.Point(152, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // studyLevelLabel
            // 
            this.studyLevelLabel.AutoSize = true;
            this.studyLevelLabel.Location = new System.Drawing.Point(6, 49);
            this.studyLevelLabel.Name = "studyLevelLabel";
            this.studyLevelLabel.Size = new System.Drawing.Size(91, 20);
            this.studyLevelLabel.TabIndex = 18;
            this.studyLevelLabel.Text = "Study Level";
            this.studyLevelLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Postgraduate",
            "Undergraduate",
            "Diploma",
            "Certificate"});
            this.comboBox2.Location = new System.Drawing.Point(152, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 28);
            this.comboBox2.TabIndex = 21;
            // 
            // session_checkBox
            // 
            this.session_checkBox.AutoSize = true;
            this.session_checkBox.Location = new System.Drawing.Point(180, 271);
            this.session_checkBox.Name = "session_checkBox";
            this.session_checkBox.Size = new System.Drawing.Size(71, 24);
            this.session_checkBox.TabIndex = 3;
            this.session_checkBox.Text = "Active";
            this.session_checkBox.UseVisualStyleBackColor = true;
            this.session_checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // sesionLabel
            // 
            this.sesionLabel.AutoSize = true;
            this.sesionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesionLabel.Location = new System.Drawing.Point(19, 271);
            this.sesionLabel.Name = "sesionLabel";
            this.sesionLabel.Size = new System.Drawing.Size(62, 18);
            this.sesionLabel.TabIndex = 13;
            this.sesionLabel.Text = "Session";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 19;
            // 
            // courselDetailsGb
            // 
            this.courselDetailsGb.Controls.Add(this.comboBox3);
            this.courselDetailsGb.Controls.Add(this.comboBox2);
            this.courselDetailsGb.Controls.Add(this.studyIntakeLabel);
            this.courselDetailsGb.Controls.Add(this.label10);
            this.courselDetailsGb.Controls.Add(this.studyLevelLabel);
            this.courselDetailsGb.Controls.Add(this.comboBox1);
            this.courselDetailsGb.Controls.Add(this.selectCourselLabel);
            this.courselDetailsGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courselDetailsGb.Location = new System.Drawing.Point(413, 45);
            this.courselDetailsGb.Name = "courselDetailsGb";
            this.courselDetailsGb.Size = new System.Drawing.Size(358, 333);
            this.courselDetailsGb.TabIndex = 19;
            this.courselDetailsGb.TabStop = false;
            this.courselDetailsGb.Text = "Course Details";
            this.courselDetailsGb.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // studyIntakeLabel
            // 
            this.studyIntakeLabel.AutoSize = true;
            this.studyIntakeLabel.Location = new System.Drawing.Point(6, 170);
            this.studyIntakeLabel.Name = "studyIntakeLabel";
            this.studyIntakeLabel.Size = new System.Drawing.Size(113, 20);
            this.studyIntakeLabel.TabIndex = 20;
            this.studyIntakeLabel.Text = "Choose Intake";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "September, 2024",
            "January, 2025"});
            this.comboBox3.Location = new System.Drawing.Point(152, 164);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(182, 28);
            this.comboBox3.TabIndex = 22;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(316, 397);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(91, 41);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Blue;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(182, 397);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(91, 41);
            this.submitBtn.TabIndex = 22;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.courselDetailsGb);
            this.Controls.Add(this.personalDetailsGb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Students\' Resgistration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.personalDetailsGb.ResumeLayout(false);
            this.personalDetailsGb.PerformLayout();
            this.courselDetailsGb.ResumeLayout(false);
            this.courselDetailsGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Label regNoLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dob_dateTimePicker;
        private System.Windows.Forms.GroupBox personalDetailsGb;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label selectCourselLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label studyLevelLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox session_checkBox;
        private System.Windows.Forms.Label sesionLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox courselDetailsGb;
        private System.Windows.Forms.Label studyIntakeLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}

