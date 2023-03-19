using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayPattern
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 4, 8 }, { 7, 8, 9, 7 }, { 4, 5, 6, 2 } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); i++)
                {
                    Console.Write(a[i,j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(".............................");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); i++)
                {
                    if (i == 0 || j == 0 || i == a.GetLength(0) -1 || j == a.GetLength(1) - 1)
                    {
                        Console.Write(a[i,j]); 
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

}
