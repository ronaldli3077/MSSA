using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while(choice =='y' ||  choice == 'Y')
            {
                CallMenu();
                Console.WriteLine("Do you want to continue ? (y/Y or N/n)");
                choice= char.Parse(Console.ReadLine());

            }
            Console.ReadKey();
        }

        static void CallMenu()
        {
            Console.WriteLine("Math operations:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter the choice in number (1,2,3,4:)");

            int choice = int.Parse(Console.ReadLine());  

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter 2 numbers:");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Sum is {Addition(num1, num2)}");  
                    break;

                case 2:
                    Console.WriteLine("Enter 2 numbers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Subtraction is {Subtraction(num1, num2)}");  
                    break;

                case 3:
                    Console.WriteLine("Enter 2 numbers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Multiplication is {Multiplication(num1, num2)}");  
                    break;

                case 4:
                    Console.WriteLine("Enter 2 numbers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Division is {Division(num1, num2)}"); 
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static int Addition(int num1, int num2)
        {
            return num1 + num2; 
        }

        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;  
        }

        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;  
        }

        static float Division(int num1, int num2)
        {
            if (num2 != 0)
            {
                return (float)num1 / num2; 
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;  
            }
        }
    }

}
