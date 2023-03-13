using MyProject.AbstractInteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AbstractInteface
{
    abstract class Animal
    {
        public abstract void MakeType();
    }
    class Dog : Animal
    {
        public override void MakeType()
        {
            Console.WriteLine("bho bho");
        }
    }
    internal class AbstractDemo1
    {
        static void Main(string[] args)
        {
            Animal x = new Dog();
            x.MakeType();
        }
    }
}

