using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.pattern
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }

    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }

    }

    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (i == 1 || j == 1 || i == row || j == row)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

    internal class Class4 //Q.5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(" * ");
                }
                {
                    Console.WriteLine();
                }
            }
        }
    }

    internal class Class5 //Q.6 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    internal class Class6 // 22feb  Q.3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || j == 4 || i == j || j == 1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    } 
