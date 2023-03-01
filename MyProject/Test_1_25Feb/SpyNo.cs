using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class SpyNo  //Q.4
    {
        static void Main(string[] args)
        {
            int sum = 0, product = 1, rev = 0;
            Console.WriteLine("Enter the no.whether it is spy or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int number1 = num;
            while (num > 0)
            {
                rev = num % 10;
                sum = sum + rev;
                product = product * rev;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("No.is spy");
            }
            else
            {
                Console.WriteLine("No is not spy");
            }
            Console.WriteLine();
        }
    }
} 
