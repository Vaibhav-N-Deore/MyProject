using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class Palindrom
    {
        static void Main(string[] args)
        {
            int num = 151;
            int temp = num;
            int res = 0;

            while (num > 0)
            {
                int digt = num % 10;
                res = res * 10 + digt;
                num = num / 10;
            }
            if (res == temp)
            {
                Console.WriteLine("Number is palindrom");
            }
        }
    }

    internal class CountNum //
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = 2392;

            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("count of number =" + count);
        }
    }

    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int num = 111;
            int temp = num;
            int rem;
            int result = 0;

            while (num > 0)
            {
                rem = num % 10;
                result = result + (rem * rem * rem);
                num = num / 10;
            }
            if (result == temp)
            {
                Console.WriteLine("Number is amstrong");
            }
            else
            {
                Console.WriteLine("Number is not amstrong");
            }
        }
    }

    internal class Averege //
    {
        static void Main(string[] args)
        {
            int num = 789;
            int sum = 0;
            int avg;
            int count = 0;

            while (num > 0)
            {
                int digt = num % 10;
                sum = sum + digt;

                num = num / 10;
                count++;
            }

            avg = sum / count;
            Console.WriteLine("avg is = " + avg);
        }
    }

    internal class Odd //write code to display odd numbers between 35 to 50 
    {
        static void Main(string[] args)
        {
            int i = 35;
            int j = 50;

            while (i <= 50)
            {
                Console.WriteLine("Odd Number :");
                i++;
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    internal class Sum1 //write code to find out the sum of 1 to 10 numbers
    {
        static void Main(string[] args)
        {
            int count=0, sum = 0;

            while (count <= 10)
            {

                Console.WriteLine("1 to 10 number are : \n");
                count++;
            }

            sum = sum + count;
            Console.WriteLine("{0}\n", count);
        }
    }
    internal class CounOdd//write code to count odd numbers between 20 to 50
    {
        static void Main(string[] args)
        {
            int i= 20;
            int j = 50;
            while(i<=50)
            {
                Console.WriteLine("count odd number :");
                i++;
            }
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }

        }
    }
}