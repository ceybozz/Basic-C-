using System;

namespace SchoolExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Kalle", 1, "CSE");
            var s2 = new Student("Rohan", 2, "CSE");
            var s3 = new Student("Mohammed", 1, "EE");
            var s4 = new Student("Abraham", 2, "EE");

            // making a list of students at the CSE depratment
            List<Student> cseStudents = new();
            cseStudents.Add(s1);
            cseStudents.Add(s2);

            // making a list of students at the EE department
            List<Student> eeStudents = new();
            eeStudents.Add(s3);
            eeStudents.Add(s4);

            // Creating departments
            var cse = new Department("CSE", cseStudents);
            var ee = new Department("EE", eeStudents);

            // Creating a list of the departments
            List<Department> departments = new();
            departments.Add(cse);
            departments.Add(ee);

            // Creating an Institute
            var institute = new Institute("QTH", departments);

            Console.WriteLine($"Total number of students in intitute: " + 
                                $"{institute.GetNumberOfStudnetsInInstitute()}");

        }
    }
}
