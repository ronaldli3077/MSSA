using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Student class
            student student = new student();

            // Assign data to properties
            Console.WriteLine("Enter Student Details:");

            Console.Write("Student ID: ");
            student.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("First Name: ");
            student.StudentFname = Console.ReadLine();

            Console.Write("Last Name: ");
            student.StudentLname = Console.ReadLine();

            Console.Write("Grade Options are A, B, C, D: ");
            student.StudentGrade = Convert.ToChar(Console.ReadLine());

            // Display the data back on the console
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"ID: {student.StudentId}");
            Console.WriteLine($"Name: {student.StudentFname} {student.StudentLname}");
            Console.WriteLine($"Grade: {student.StudentGrade}");

            Console.ReadKey();
        }
    }
}
