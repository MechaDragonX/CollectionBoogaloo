using System;

namespace Link
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student Next { get; set; }

        /// <summary>
        /// Creates a new Student
        /// </summary>
        /// <param name="name">Student's Name</param>
        /// <param name="age">Student's Age</param>
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Next = null;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}", Name, Age);
        }
    }
}
