using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfacesdemo1
{
    internal interface IgenericMath<T>
    {
        T Add(T x, T y);
        T Multiply(T x, T y);
    }

    class Math<T> : IgenericMath<T>
    {
        public T Add(T x, T y)
        {
            throw new NotImplementedException();
        }

        public T Multiply(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}
