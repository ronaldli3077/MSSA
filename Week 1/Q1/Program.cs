using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter two integer numbers");
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Checknumbers(num1, num2);    //如果需要修改比较逻辑，只需要改动Checknumbers方法，而不必更改Main方法。

            Console.ReadKey();
        }

        static void Checknumbers(int num1, int num2)   // 在程序中定义了一个方法static void Checknumbers(int num1, int num2)，表示有一个功能模块，用来接收两个整数并比较它们是否相等。
        {
           

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else 
            {
                Console.WriteLine($"{num1} is not equal to {num2}");
            }
        }
        //流程总结
        //1.  Main 方法 启动用户通过控制台输入两个数字，赋值给num1和num2。
        //2.  调用Checknumbers(num1, num2)，把num1和num2的值传递给Checknumbers，
        //3.  Checknumbers方法接收到这两个值并进行比较，然后输出结果。
        // 也可把if逻辑放到main方法里面，但是会使得整个program变得臃肿
    }
}
