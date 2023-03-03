using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop.Pattern_Program.No_Pattern
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            /* 1 
               22
               333
               4444
               55555*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }

    class Class2
    {
        static void Main(string[] args)
        {
            /* 1
               12
               123
               1234
               12345*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            /* 5
               54
               543
               5432
               54321*/

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class Class4
    {
        static void Main(string[] args)
        {
            /* 12345
               2345
               345
               45
               5*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
    class LeftTriangle1
    {
        static void Main(string[] args)
        {
            /*   
                     1
                    12
                   123
                  1234
                 12345*/


            for (int i = 1; i <= 5; i++)
            {
                for (int space = 1; space <= 5 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        class LeftTriangle2
        {
            static void Main(string[] args)
            {
                /*
                         6
                        56
                       456
                      3456
                     23456
                    123456 */

                for (int i = 6; i >= 1; i--)
                {
                    for (int space = 1; space <= i - 1; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = i; j <= 6; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
