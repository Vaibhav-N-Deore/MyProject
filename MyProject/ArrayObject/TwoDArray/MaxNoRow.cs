using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    internal class MaxNoRow
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 5, 3 }, { 1, 5, 9 }, { 2, 5, 8 } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.WriteLine(a[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("................................");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, i];
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine(" max= " + max);
            }
        }
    }
}

