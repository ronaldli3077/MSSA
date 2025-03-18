using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calculateSize = true;     //假设这个是true的话，会有什么选择

            while (calculateSize)
            {
                Console.WriteLine("Select shape of to calculate size of the the area:");
                Console.WriteLine("1. Triangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Rectangle:");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your options: 1,2,3,4");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CalculateTriangle ();  //注意这里开始要
                        break;
                    case 2: 
                        CalculateSquare();
                        break;
                    case 3: 
                        CalculateRectangle();
                        break;
                    case 4:
                        calculateSize = false;
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }


            }
            Console.WriteLine("Press any key to exit"); // 当我 
            Console.ReadKey();  //readkey should be inside main method 
        }
        static void CalculateTriangle()
        {

                Console.WriteLine("Enter the length:");
                double trilength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height:");
                double triheight = double.Parse(Console.ReadLine());
                double size = trilength * triheight * 0.5;
                Console.WriteLine($"the size of Trangle is {size}.");


        }

        static void CalculateRectangle()
        {

                Console.WriteLine("Enter the length:");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width:");
                double width = double.Parse(Console.ReadLine());
                double size = length * width;
                Console.WriteLine($"the size of Rectangle is {size}.");


        }

         static void CalculateSquare()
         {

                Console.WriteLine("Enter the side:");
                double side = double.Parse(Console.ReadLine());
                
                double size = side * side;
                Console.WriteLine($"the size of Square is {size}.");


          }

       
    }
}
