using System;
using System.Collections.Generic;

namespace StudentAdvisorApp
{
    public class Professor : Person
    {
        private List<Student> advisees;

        public Professor(string name, string major)
            : base(name, major)
        {
            advisees = new List<Student>();
        }

        public void AddAdvisee(Student student)
        {
            advisees.Add(student);
            student.Advisor = this;
        }

        public List<Student> GetAdvisees()
        {
            return advisees;
        }

        public override string ToString()
        {
            return $"{Name} ({Major})";
        }
    }
}