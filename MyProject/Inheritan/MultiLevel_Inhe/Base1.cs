using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritan.MultiLevel_Inhe
{
    internal class Base1
    {
        public string name;
        class Son : Father
        {
            public void DisplayTwo()
            {
                Console.WriteLine("Son.. ");
            }
            static void Main(string[] args)
            {
                Son s = new Son();
                s.Display();
                s.DisplayOne();
                s.DisplayTwo();
                Console.Read();
            }
        }
        class Grandfather
        {
            public void Display()
            {
                Console.WriteLine("Grandfather...");
            }
        }
        class Father : Grandfather
        {
            public void DisplayOne()
            {
                Console.WriteLine("Father...");
            }
        }
    }
}
