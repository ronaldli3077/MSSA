using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod7Inheritancedemo;

namespace Mod7Inheritancedemo
{
    //since its bank so its intenral 
    internal class BankAccount
    {
        // 这里如果有private, it will stay in class
        // protected ， it will see from inhertiataed class in below 
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        //  下面这段 it is inherited in derived class, but hidden from client code 
        // 因为是protected, 所以只能被BankAccount class或者其子类访问，也就是41行
        protected double minBalance;

        //MinBalance 就像“一个只读的公告栏”，外人（客户端代码）可以查看公告栏上的内容（读取 minBalance 的值），
        //但不能修改公告栏上的内容。
        // this is 继承了derived class, but hidden from clident code
        // 这里的public value 需要return protected , 因为两者需要一个relationship build
        public double MinBalance { get { return this.minBalance; } }
        
        
        

    // 可以在一个file下建立class
    //问自己一个问题, savingaccount是不是bank account，如果是，则可以继承Bankaccount
    // 下面这段就是定义了savingaccount 是属于bankaccount的
    class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {
            this.minBalance = 300; //random value
            
        }
    }

    }
    class CheckingAccount : BankAccount
    {
    public CheckingAccount()
    {
        this.minBalance = 50;
    }


      
   
}


