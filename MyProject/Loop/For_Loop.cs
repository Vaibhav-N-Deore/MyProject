using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class OddEven //write code to display odd numbers between 35 to 50 
    {
        static void Main(string[] args)
        {
            int i = 35; int j = 50;

            Console.WriteLine("Odd Numbers :");
            for (i = 35; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
    internal class Sum //write code to find out the sum of 1 to 10 numbers
    {
        static void Main(string[] args)
        {

            int count, sum = 0;

            Console.Write("1 to 10 number are : \n");

            for (count = 1; count <= 10; count++)
            {
                sum = sum + count;
                Console.Write(" {0}\n", count);
            }
            Console.WriteLine("sum is : {0}\n", sum);


        }
    }

    internal class CountOdd //write code to count odd numbers between 20 to 50
    {
        static void Main(string[] args)
        {
            int i = 20; int j = 50;

            Console.WriteLine("Count Odd Numbers :");

            for (i = 20; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    internal class Table //write code to find out numbers between 320 to 225
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the number for table");
            int n = int.Parse(Console.ReadLine());

            for (int i = 320; i >= 225; i--)
            {
                Console.WriteLine(i);
            }
        }


    }

    internal class DisplayTable //write code to display table of given no.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for table");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n * i);
            }
        }
    }

}


