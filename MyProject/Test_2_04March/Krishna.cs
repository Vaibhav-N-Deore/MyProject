using MyProject.Test_Loop_25Feb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
    internal class Krishna //Q.8
    {
        static void Main(string[] args)
        {
            int number, sum, digit, fact;
            Console.WriteLine("Enter the number ");
            number = Convert.ToInt32(Console.ReadLine());
            int no1 = number;
            sum = 0;
            while (no1 != 0)
            {
                digit = no1 % 10;
                fact = 1;


                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }

                sum = sum + fact;
                no1 = no1 / 10;
            }
            if (sum == number)
            {
                Console.WriteLine("Number is Krishnamurthy");
            }
            else
            {
                Console.WriteLine("Number is Not Krishnamurthy");
            }
                Console.Read();


        }
    }
}