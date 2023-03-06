using MyProject.Loop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
    internal class Harshad //Q.5
    {
        static void Main(string[] args)
        {
            int sum = 0, r;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int No = num;

            while (num> 0)
            {
                r= num % 10;
                sum = sum + r;
                num = num / 10;
            }

            if (num % No == 0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not a Harshad Number");
            }
        }
    }
}
