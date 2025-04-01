using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Overloadingdemo
{
    //overload 就是same name method with same name calss , but differnt parameter
    // override: across the class in inheritance
    // static class can't be instantiated and inheritance
    
    public void Test () // 这里报错是因为Normal method 需要一个object  
    
    
    internal class OutputFormatter
    {
        //这里用了static, 这样做可以without creating any object of this class, we can invoke this method
        // static will using under utility class or you want to have functionlity to invode methods
        public static void DisplayName (string firstname) 
        {
            Console.WriteLine ($"Welcome {firstname}, enjoy the course!");
        }

        //这里same class, same method, no inheritance
        public static void DisplayName (string firstname, string lastname)
        {
            Console .WriteLine ($"Hello {firstname} {lastname}, welcome to the course");
        }
    }


}
