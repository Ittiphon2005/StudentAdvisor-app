    using System;

    namespace StudentAdvisorApp
    {
        public abstract class Person
        {
            private string name;
            private string major;

            public Person(string name, string major)
            {
                this.name = name;
                this.major = major;
            }

            public string Name
            {
                get => name;
                set => name = value;
            }

            public string Major
            {
                get => major;
                set => major = value;
            }

            public abstract override string ToString();
        }
    }