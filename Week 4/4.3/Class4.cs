using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mod5Demo1
{
    internal static class ExtensionmMethodsClass
    {
        public static bool ContainsNumbner(this string s) //检查字符串 (string s) 是否包含数字 (0-9)。
        {
            return Regex.IsMatch(s, "\\d"); //if find any digit, return true
        }

        public static bool CheckValue(this int obj, int val) // obj > val：判断 obj 是否比 val 大
        {
            return obj > val; // if 大于, return True ， 如果没有的大于，return false
        }
    }
}
