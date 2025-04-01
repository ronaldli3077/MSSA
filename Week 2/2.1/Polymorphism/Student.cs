using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphism
{
    internal class Student:Person
    {
        public float GPA {  get; set; }
        // abstract-override ( compulsion)
        public override void FollowSchedule()
        {
            Console.WriteLine("I am in virtual class room from 8 to 4 pst");
        }
        // virtual-override (choice)
        public override void DoWork()
        {
            //base.DoWork();
            Console.WriteLine("I do c# assignments/ projects"); //这里是把Person里面的dowork override了
        }
    }
}
