using System;

namespace StudentAdvisorApp
{
    public class Student : Person
    {
        private string studentId;
        private double grade;
        private Professor advisor;

        public Student(string studentId, string name, string major, double grade, Professor advisor)
            : base(name, major)
        {
            this.studentId = studentId;
            this.grade = grade;
            this.advisor = advisor;
        }

        public string StudentId => studentId;
        public double Grade => grade;
        public Professor Advisor
        {
            get => advisor;
            set => advisor = value;
        }

        public override string ToString()
        {
            return $"ID: {studentId}, Name: {Name}, Major: {Major}, Grade: {grade}, Advisor: {advisor?.Name ?? "None"}";
        }
    }
}