using System;

namespace SchoolExample
{
    public class Student
    {
        private string name;
        private int id;
        private string department;

        public Student(string name, int id, string dept)
        {
            this.name = name;
            this.id = id;
            this.department = dept;
        }
    }
}
