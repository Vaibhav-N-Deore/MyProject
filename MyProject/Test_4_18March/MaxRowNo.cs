using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_4_18March
{
    internal class MaxRowNo
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 2, 8 }, { 1, 4, 9 }, { 1, 5, 7 } };

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

