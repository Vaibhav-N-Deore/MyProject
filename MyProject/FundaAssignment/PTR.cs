using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class PTR //Q.3.Write a  program to enter P, T, R and calculate Compound Interest.
    {
        static void Main(string[] args)
        {
            float p, t, r;
            float amount, ci;
            Console.WriteLine("Enter amount, time and rate of interest to calculate compound interest\n");
            Console.Write("amount:\t");

            p = float.Parse(Console.ReadLine());
            Console.Write("Time:\t");
            t = float.Parse(Console.ReadLine());

            Console.Write("Rate of Interest:\t");
            r = float.Parse(Console.ReadLine());

            amount = p * (float)Math.Pow((1 + r / 100), t);
            ci = amount - p;

            Console.WriteLine("Compound Interest:\t{0}", ci);
            Console.WriteLine("Total Amount Payable:\t{0}", amount);
        }
    }
}
