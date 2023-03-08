using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class CaAvPe  //Q.1.Write a program to enter marks of five subjects and calculate total, average and percentage
    {
        static void Main(string[] args)
        { 
            int marks1, marks2, marks3, marks4,marks5;
            int total;
            float percentage;
            float average;
            string division;

            Console.WriteLine("Enter the marks of subject 1: ");
            marks1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 2: ");
            marks2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 3: ");
            marks3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 4: ");
            marks4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 5: ");
            marks5 = int.Parse(Console.ReadLine());

            total = marks1 + marks2 + marks3 +marks4 + marks5;
            percentage = (total / 500) * 100;
            average = total / 5;

            if (percentage >= 60)
            {
                division = "First Division";
            }
            else if (percentage >= 45)
            {
                division = "Second Division";
            }
            else
            {
                division = "Third Division";

            }
        }
    }
}
