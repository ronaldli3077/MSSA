using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Mod7Overloadingdemo
{
    internal class A
    {
        public int Id { get; set; }  //多的一个property
        public virtual void Method1 ()
        {
            Console.WriteLine($"In method 1 from class A");
        }
    }
   
    class B:A
    {
        public void Method2() { }
        
        public override void Method1() //B继承了A 然后又override A的方法
        {
            Console.WriteLine("In method1 from class B");
        }
    }

}
