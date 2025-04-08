using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Mod1RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            input:
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            if(ContainsDigits(name))
            {
                Console.WriteLine("Enter only letters!");
                goto input;
            }
            else
            {
                emailinput:
                Console.WriteLine($"{name} , please enter your email id");

                string email=Console.ReadLine();
                if(CheckEmail(email))
                {
                    Console.WriteLine($"{name} , you are registered successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid email format, please reenter");
                    goto emailinput;
                }
            }
            Console.ReadKey();

        }

        static bool CheckEmail(string email)
        {
            string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email,emailpattern);
        }
        static bool ContainsDigits(string s)
        {
            return Regex.IsMatch(s, "\\d");
            
        }

    }
}
