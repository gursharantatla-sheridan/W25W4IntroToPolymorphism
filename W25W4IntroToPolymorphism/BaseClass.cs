using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W25W4IntroToPolymorphism
{
    public class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("Base class Show method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("Derived class Show method");
        }
    }
}
