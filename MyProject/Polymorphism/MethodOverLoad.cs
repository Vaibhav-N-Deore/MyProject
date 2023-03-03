using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Polymorphism
{
    internal class MethodOverLoad
    {
        public void Area(int r)
        {
            double pi = 3.14;
            Console.WriteLine("Area of Circle=" + (pi * r * r));
        }
        public void Area(int b, int h)
        {
            Console.WriteLine("Area of Triangle=" + ((1 / 2) * b * h));
        }
        public void Area(int l, float b)
        {
            Console.WriteLine("Area of Rectangle=" + (l * b));
        }
        public void Area(float s)
        {
            Console.WriteLine("Area=" + (s * s));
        }
         
        static void Main(string[] args)
        {

                MethodOverLoad overload =new MethodOverLoad();
                overload.Area(5);
                overload.Area(4, 5);
                overload.Area(5, 4.5f);
                overload.Area(4.5f);
            
        }
    }
}
