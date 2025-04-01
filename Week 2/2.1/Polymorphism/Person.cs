using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphism
{
    //abstract class serves as a base template but cannot be instantiated
    // we write the abstract classes to build class hierarchy and not allow object creation
    internal abstract class Person
    {
        private string firstName;
        // auto properties will create their own private backing fields
        public string FirstName {
            get { 
                // get block helps to change the way data is returned
                return this.firstName.ToUpper();
                }
            set // validation
            {
                if(value.Length<=50)
                {
                    this.firstName = value;
                }
                else
                {
                   // trim the value and make it fit in 50 characters
                }

            }
        
        
        }

        public string LastName { get;set; }// auto
        public int Age {  get; set; }
        public string Address {  get; set; }
        public void Communicate()
        {
            Console.WriteLine("I use a language to communicate!");
        }
       



        public virtual void DoWork()
        {
            Console.WriteLine("I do some work");
        }
        // abstract methods only belong to abstract classes
        // you must implement the abstract method in derived class



        public abstract void FollowSchedule();
        // normal classes =instance classes : those which can be instantiated
        //这里的followscheudle只是一个statement，还需要一个子类去override后然后实现，在student里面可以看到
        

        
    }
}
