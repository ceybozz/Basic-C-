using System;

namespace SchoolExample
{
    public class Institute
    {
        private string name;
        private List<Department> departments;
        public Institute(string name, List<Department> departments)
        {
            this.name = name;
            this.departments = departments;
        }

        public int GetNumberOfStudnetsInInstitute()
        {
            int noOfStudents = 0;
            List<Student> students;

            foreach (Department dept in departments)
            {
                students = dept.Students;
                foreach (var student in students)
                {
                    noOfStudents++;
                }
            }
            return noOfStudents;
        }
    }
}
