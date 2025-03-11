using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentAdvisorApp
{
    public partial class Form1 : Form
    {
        private List<Professor> professors;
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            professors = new List<Professor>();
            students = new List<Student>();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentId == null || txtName == null || txtMajor == null || txtGrade == null || txtAdvisor == null || nameStudent == null)
            {
                MessageBox.Show("Some controls are not initialized! Check Designer file.");
                return;
            }

            string studentId = txtStudentId.Text;
            string name = txtName.Text;
            string major = txtMajor.Text;
            string advisorName = txtAdvisor.Text;

            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(major) || string.IsNullOrWhiteSpace(advisorName))
            {
                MessageBox.Show("Please fill all fields (Student ID, Name, Major, Advisor)!");
                return;
            }

            double grade;
            if (!double.TryParse(txtGrade.Text, out grade) || grade < 0 || grade > 4)
            {
                MessageBox.Show("Please enter a grade between 0 and 4");
                return;
            }
            Professor advisor = professors.Find(p => p.Name.Equals(advisorName, StringComparison.OrdinalIgnoreCase));
            if (advisor == null)
            {
                advisor = new Professor(advisorName, major);
                professors.Add(advisor);
                MessageBox.Show($"Added new advisor: {advisorName}");
            }

            Student newStudent = new Student(studentId, name, major, grade, advisor);
            advisor.AddAdvisee(newStudent);
            students.Add(newStudent);

            nameStudent.Items.Add(newStudent.ToString());
            nameStudent.Refresh();
            MessageBox.Show($"Added: {newStudent.ToString()}");

            txtStudentId.Clear();
            txtName.Clear();
            txtMajor.Clear();
            txtGrade.Clear();
            txtAdvisor.Clear();
        }

        private void btnShowTopStudent_Click(object sender, EventArgs e)
        {
            if (students == null || students.Count == 0 || txtTopStudent == null)
            {
                MessageBox.Show("No student data available");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            if (topStudent != null)
            {
                txtTopStudent.Text = $"Top student: {topStudent.Name} ({topStudent.Grade})";
            }
            else
            {
                txtTopStudent.Text = "No top student data found";
            }
        }

        private void btnShowAdvisees_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdvisor.Text))
            {
                MessageBox.Show("Please enter the advisor's name");
                return;
            }

            string advisorName = txtAdvisor.Text;
            Professor selectedProfessor = professors.Find(p => p.Name.Equals(advisorName, StringComparison.OrdinalIgnoreCase));

            if (selectedProfessor == null)
            {
                MessageBox.Show("Advisor not found");
                return;
            }

            List<Student> advisees = selectedProfessor.GetAdvisees();

            nameStudent.Items.Clear();

            if (advisees.Count > 0)
            {
                foreach (Student student in advisees)
                {
                    nameStudent.Items.Add(student.ToString());
                }
            }
            else
            {
                nameStudent.Items.Add("No students under this advisor");
            }

            nameStudent.Refresh();
        }
    }
}