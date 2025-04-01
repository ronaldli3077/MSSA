using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student newStudent = new Student();
            newStudent.FirstName = "Deepali";
            newStudent.LastName = "K";
            newStudent.Address = "NY";
            newStudent.Age = 42;
            newStudent.GPA = 4.5f;
            Console.WriteLine($"{newStudent.FirstName} living in {newStudent.Address} has GPA of{newStudent.GPA}");
            newStudent.Communicate();
            newStudent.DoWork();
            newStudent.FollowSchedule();


            Instructor instructor=new Instructor ();
            instructor.FirstName = "Amy";
            instructor.Salary = 5000;
            Console.WriteLine($"{instructor.FirstName} has salary ${instructor.Salary}");
            instructor.FollowSchedule();
            instructor.DoWork();



            Console.ReadKey();
        }
    }
}
