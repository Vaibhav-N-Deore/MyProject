using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic
{
    internal class Addition
    {
        static void Main(string[] args)
        {

            int num1 = 5;
            int num2 = 7;
            int Addition = num1 + num2;
            Console.WriteLine("sum = " + Addition);

        }


    }

    internal class largeNum
    {

        static void Main(string[] args)
        {
            int a = 50;
            int b = 90;
            int largeNum;

            if (a > b)
            {
                largeNum = a;
            }
            else
            {
                largeNum = b;
            }
            Console.WriteLine(" a: " + a);
            Console.WriteLine(" b: " + b);
            Console.WriteLine("large number is: " + largeNum);



        }
    }

    internal class CheckNum
    {

        static void Main(string[] args)
        {
            int a = 85;

            if (a > 0)
            {
                Console.WriteLine("positiveNumber");
            }

            else
            {
                Console.WriteLine("NegativeNumber");
            }

        }

    }


    internal class Circle
    {
        static void Main(string[] args)
        {
            int r;
            r = 20;

            Console.WriteLine("Radius: ");
            double Area = Math.PI * r * r;
            Console.WriteLine("Area of circle: " + Area);

        }
    }

}


