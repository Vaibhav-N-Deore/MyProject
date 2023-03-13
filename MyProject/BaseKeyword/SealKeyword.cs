using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseKeyword
{
    internal class SealKeyword
    {
        const int a = 5;
        readonly int b;
        public SealKeyword()
        {
            b = 10;
            Console.WriteLine("b: "+b);

        }
        public virtual void Print()
        {
            Console.WriteLine("in 1st class");
            Console.WriteLine("a: " + a);
        }
    }

    internal class NonSealed :SealKeyword
    {
        public sealed override void Print()
        {
            base.Print();
            Console.WriteLine("In 2nd class");
        }
    }
}
