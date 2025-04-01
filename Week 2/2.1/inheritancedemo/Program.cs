using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Inheritancedemo
{
    // client code  is Main method
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(); //创建object 对象
            SavingsAccount savingsAccount = new SavingsAccount(); //创建object 对象，这里savingaccount继承了 bankaccount的属性
            savingsAccount.AccountNumber = 22424;    //设置属性
            savingsAccount.HolderName = "Frank S";   //设置属性

            Console.WriteLine($"for account {savingsAccount.AccountNumber} please see the balance:"); // 这里从控制台读取用户输入的余额，并通过 set 方法设置 Balance 属性。
            double balance = double.Parse( Console.ReadLine() );
            if ( balance >= savingsAccount.MinBalance )
            {
                savingsAccount.Balance = balance;
            }
            Console.WriteLine($"Balance is {savingsAccount.Balance}"); //这里通过 get 方法读取 Balance 属性并显示出来
            Console.ReadKey();



            CheckingAccount checkingAccount = new CheckingAccount();    //这里创建了一个 CheckingAccount 对象，并显示其最低余额要求。
            Console.WriteLine($"min balance for checking is {checkingAccount.MinBalance}");
            Console.ReadKey();

        }
    }
}
