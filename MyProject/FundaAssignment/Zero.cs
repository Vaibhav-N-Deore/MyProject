using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class Zero //Q.6.WAP to check whether a number is negative, positive or zero 
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is nagative ");
            }
            else
            {
                Console.WriteLine("Number is zero ");
            }

        }
    }

}

