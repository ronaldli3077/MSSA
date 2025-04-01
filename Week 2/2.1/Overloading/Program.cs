using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Overloadingdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            A objA = new A(); //创建了一个 A 类的实例 objA。
            objA.Method1(); //objA 调用了method 1

            B objB= new B(); //创建了一个 B 类的实例 objB。
            objB.Method1();  //调用 objB 的 Method1 方法


            A obj1 = new B(); // 创建了一个A类型的变量 Obj1, 然后来创建了一个B类型的实列，但是要确保B类型是A类型的子类
            //编译时类型是 A，运行时类型是 B
            obj1.Method1(); //然后调用了一个B类型的method，




            //额外问题
            //obj1. //因为我在21行申明呢 A obj1 这个，所以 obj1属于A类
            obj1.Id 可以调用
            obj1.Method1 可以调用
            obj1.Method2 不可以 因为method2 在B类，而obj1在A类
            // 注意！！！ 左边是编译时类型，决定了你可以访问哪些成员。


            B obj2= new A(); //  因为子类（B）不能继承自父类（A），因为子类B对象总是具备父类A的所有特性。





            //utility class typicall holds functions together and may not need propreties to hold data
            //make the functions as static
            OutputFormatter.DisplayName("Ron");// first 
            OutputFormatter.DisplayName("Ron", "L"); //second 



            Service firstservice = new Service();
            firstservice.ServiceId = 1;
            firstservice.ServiceName = "Create";
            firstservice.StartService(1, "Create");
            Console.WriteLine($"is service running {firstservice.IsRunning}");


            Console.ReadKey();
        }
    }
}
