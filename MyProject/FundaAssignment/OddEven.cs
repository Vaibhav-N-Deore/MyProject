using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class OddEven //Q.8.WAP to check whether a number is even or odd  
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number" + n);
            }
            else
                Console.WriteLine("Odd Number" + n);
        }
    }
}
