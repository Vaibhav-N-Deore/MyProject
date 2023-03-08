using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class Divisible //Q.2.WAP to check whether a number is divisible by 5 and 11 or not 
    {
        static void Main(string[] args)
        {
            int num;
            num = 55;

            Console.WriteLine("Number: " + num);

            // if the number is divisible by 5 and 11

            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not divisible by 5 and 11");
            }
        }
    }
}
