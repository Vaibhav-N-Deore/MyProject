﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment2
{
    internal class GCDLCM //Q.4
    {
        static void Main()
        {
            long num1, num2, hcf, lcm;
            Console.WriteLine("Find the LCM and GCD of two numbers :");
            Console.WriteLine("------------------------------------------------------");

            Console.Write(" Enter the 1st number : ");
            num1 = Convert.ToInt64(Console.ReadLine());

            Console.Write(" Enter the 2nd number : ");
            num2 = Convert.ToInt64(Console.ReadLine());

            hcf = gcd(num1, num2);
            lcm = (num1 * num2) / hcf;

            Console.WriteLine("\n The GCD of {0} and {1} = {2} ", num1, num2, hcf);
            Console.WriteLine(" The LCM of {0} and {1} = {2}\n", num1, num2, lcm);
        }
        static long gcd(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }
    }   
}
