using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.pattern
{
    internal class NoPattern //Q.1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                {
                    Console.WriteLine();
                }
            }
        }
    }

    internal class Class5 //Q.2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                {
                    Console.WriteLine();
                }
            }
        }
    }


    internal class Class6 //Q.3  
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                {
                    Console.WriteLine();
                }
            }
        }
    }
    internal class Class7 //Q.4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j);
                }
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
