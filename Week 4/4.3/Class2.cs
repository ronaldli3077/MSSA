using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo1
{
    internal class A
    {
        private int id;
        protected int x;
    }

    class B : A
    {
        public void Test()
        {
            base.x = 1; // 是不是这里的x 可以access class A的x，但是 class A的x ，不能从main method access

        }


    }
}

