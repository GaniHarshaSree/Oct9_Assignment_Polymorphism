using System;
using StudEmpLib;

namespace Polymorphism
{
    internal class MainProgram
    {
            static void Main(string[] args)
            {

                Student s2 = new Student(101, "Harsha");
                Student s3 = new Student(101, "Harsha", 23);
                s3.Maths = 80;
                s3.English = 85;
                s3.Science = 90;
                s3.Calculate();
                Console.WriteLine($" Student Id : {s3.StudentId} \n Student Name : {s3.StudentName} \n Student Age : {s3.StudentAge}");
                Console.WriteLine("");
                Employee employee = new Employee();
                employee.Empid = 001;
                employee.EmpName = "Harsha";
                employee.Salary = 21000;
                employee.Calculate();
                Console.ReadLine();
            }
    }
}
