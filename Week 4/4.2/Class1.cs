using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfacesdemo1
{
    internal abstract class AbstractClass
    {
        public void NormalMethod()
        {

        }
        public virtual void VirtualMethod()
        {
            //logic
        }
        public abstract void AbstractMethod();

    }
     class DerivedClass:AbstractClass
    {
        public override void AbstractMethod()
        {
            throw new NotImplementedException();
        }
        public override void VirtualMethod()
        {
            base.VirtualMethod();
        }
    }
    class B
    {

    }
    // Multiple inheritance not allowed
    class A:DerivedClass
    {

    }
    
}
