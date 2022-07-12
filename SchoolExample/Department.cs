using System;

namespace SchoolExample
{
    public class Department
    {
        private string name;
        public List<Student> Students { get; private set; }
        public Department(string name, List<Student> students)
        {
            this.name = name;
            Students = students;
        }
    }
}
