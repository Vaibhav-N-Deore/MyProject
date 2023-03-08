using MyProject.Inheritan.Single_Inhe;
using MyProject.Loop.If_Else;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class Program //Q.1. Write a program to calculate area of an equilateral triangle.
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Length of Side:\t");
            float side = float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of Equilateral Triangle is:\t" + area);
        }

    }
}
