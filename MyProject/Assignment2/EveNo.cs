using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment2
{
    internal class EveNo //Write a program to print even numbers from 121 to 229 using for loop. 
    {
        static void Main(string[] args)
        {
            int i = 0;

                Console.WriteLine("Even Numbers :");

              for (i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)

                {
                   Console.Write(i + " ");
                }
            }

                /*   Console.WriteLine("\nOdd Numbers :");

              for (i = 1; i <= 30; i++)
            {
                 if (i % 2 != 0)

                 {
                   Console.Write(i + " ");
                 }
            }*/
            
        }
    }
}
