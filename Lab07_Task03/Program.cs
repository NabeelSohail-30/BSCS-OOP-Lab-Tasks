using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.RegMethod();
            c.AbstractMethod();
            SealedClass s = new SealedClass();
            s.AboutMe();
            Console.Read();
        }
    }

    abstract class AbstractClass
    {
        abstract public void AbstractMethod();

        public void RegMethod()
        {
            Console.WriteLine("Regular Method in base class");
        }
    }

    class Child : AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract Method implemented in Child Class");
        }
    }

    sealed class SealedClass
    {
        public void AboutMe()
        {
            Console.WriteLine("Method from Sealed Class");
        }
    }
}
