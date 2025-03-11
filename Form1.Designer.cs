namespace StudentAdvisorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtAdvisor;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ListBox nameStudent;
        private System.Windows.Forms.Button btnShowTopStudent;
        private System.Windows.Forms.TextBox txtTopStudent;
        private System.Windows.Forms.Button btnShowAdvisees;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblStudentId = new Label();
            lblName = new Label();
            lblMajor = new Label();
            lblGrade = new Label();
            lblAdvisor = new Label();
            txtStudentId = new TextBox();
            txtName = new TextBox();
            txtMajor = new TextBox();
            txtGrade = new TextBox();
            txtAdvisor = new TextBox();
            btnAddStudent = new Button();
            nameStudent = new ListBox();
            btnShowTopStudent = new Button();
            txtTopStudent = new TextBox();
            btnShowAdvisees = new Button();
            SuspendLayout(); 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(27, 31);
            lblStudentId.Margin = new Padding(4, 0, 4, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(79, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID";
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 77);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            lblMajor.AutoSize = true;
            lblMajor.Location = new Point(27, 123);
            lblMajor.Margin = new Padding(4, 0, 4, 0);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(48, 20);
            lblMajor.TabIndex = 4;
            lblMajor.Text = "Major";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(27, 169);
            lblGrade.Margin = new Padding(4, 0, 4, 0);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(49, 20);
            lblGrade.TabIndex = 6;
            lblGrade.Text = "Grade";
            // 
            // lblAdvisor
            // 
            lblAdvisor.AutoSize = true;
            lblAdvisor.Location = new Point(27, 215);
            lblAdvisor.Margin = new Padding(4, 0, 4, 0);
            lblAdvisor.Name = "lblAdvisor";
            lblAdvisor.Size = new Size(59, 20);
            lblAdvisor.TabIndex = 8;
            lblAdvisor.Text = "Advisor";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(133, 31);
            txtStudentId.Margin = new Padding(4, 5, 4, 5);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(199, 27);
            txtStudentId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 77);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 3;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(133, 123);
            txtMajor.Margin = new Padding(4, 5, 4, 5);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(199, 27);
            txtMajor.TabIndex = 5;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(133, 169);
            txtGrade.Margin = new Padding(4, 5, 4, 5);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(199, 27);
            txtGrade.TabIndex = 7;
            // 
            // txtAdvisor
            // 
            txtAdvisor.Location = new Point(133, 215);
            txtAdvisor.Margin = new Padding(4, 5, 4, 5);
            txtAdvisor.Name = "txtAdvisor";
            txtAdvisor.Size = new Size(199, 27);
            txtAdvisor.TabIndex = 9;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(182, 258);
            btnAddStudent.Margin = new Padding(4, 5, 4, 5);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(133, 46);
            btnAddStudent.TabIndex = 10;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // nameStudent
            // 
            nameStudent.Location = new Point(347, 31);
            nameStudent.Margin = new Padding(4, 5, 4, 5);
            nameStudent.Name = "nameStudent";
            nameStudent.Size = new Size(399, 224);
            nameStudent.TabIndex = 11;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(340, 258);
            btnShowTopStudent.Margin = new Padding(4, 5, 4, 5);
            btnShowTopStudent.Name = "btnShowTopStudent";
            btnShowTopStudent.Size = new Size(133, 46);
            btnShowTopStudent.TabIndex = 12;
            btnShowTopStudent.Text = "Show Top";
            btnShowTopStudent.Click += btnShowTopStudent_Click;
            // 
            // txtTopStudent
            // 
            txtTopStudent.Location = new Point(481, 277);
            txtTopStudent.Margin = new Padding(4, 5, 4, 5);
            txtTopStudent.Name = "txtTopStudent";
            txtTopStudent.ReadOnly = true;
            txtTopStudent.Size = new Size(265, 27);
            txtTopStudent.TabIndex = 13;
            // 
            // btnShowAdvisees
            // 
            btnShowAdvisees.Location = new Point(27, 258);
            btnShowAdvisees.Margin = new Padding(4, 5, 4, 5);
            btnShowAdvisees.Name = "btnShowAdvisees";
            btnShowAdvisees.Size = new Size(133, 46);
            btnShowAdvisees.TabIndex = 14;
            btnShowAdvisees.Text = "Show Advisor";
            btnShowAdvisees.Click += btnShowAdvisees_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblMajor);
            Controls.Add(txtMajor);
            Controls.Add(lblGrade);
            Controls.Add(txtGrade);
            Controls.Add(lblAdvisor);
            Controls.Add(txtAdvisor);
            Controls.Add(btnAddStudent);
            Controls.Add(nameStudent);
            Controls.Add(btnShowTopStudent);
            Controls.Add(txtTopStudent);
            Controls.Add(btnShowAdvisees);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Student Advisor System";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}