using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic
{
    internal class Rectangle
    {
        static void Main(string[] args)
        {
            double length, breadth, area;
            Console.WriteLine("Enter length of rectangle : ");

            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle : ");

            breadth = Convert.ToDouble(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("\nArea of rectangle: " + area);
            Console.ReadKey();
        }
    }


    internal class circle
    {

        static void Main(string[] args)
        {
            int r;
            double A;

            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            A = 3.14 * r * r;
            Console.WriteLine("The Area of circle = " + A);
        }

    }

    internal class Average
    {
        static void Main()
        {

            Console.WriteLine("Please write your 1st number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Please write your 2nd number: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Please write your 3rd number: ");
            double c = double.Parse(Console.ReadLine());

            double average = (a + b + c) / 3;
            Console.WriteLine("The average sum of these 3 numbers is: {0:F5}", average);
        }
    }
    internal class percentage
    {
        static void Main(string[] args)
        {
            double rl, phy, che, ca, total;
            double per;
            string nm, div;

            Console.Write("\n\n");
            Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the Roll Number of the student :");
            rl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());

            total = phy + che + ca;
            per = total / 3.0;
            if (per >= 60)
                div = "First";
            else
            if (per < 60 && per >= 48)
                div = "Second";
            else
                if (per < 48 && per >= 36)
                div = "Pass";
            else
                div = "Fail";

            Console.Write("Roll No : {1}\n", rl, nm);
            Console.Write("Marks in Physics : ", phy, che, ca);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
        }

    }

    internal class oddeven
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter the no. to check odd or even ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Number is Even ");
            }
            else
            {
                Console.WriteLine("Number is odd ");
            }
        }
    }


}
