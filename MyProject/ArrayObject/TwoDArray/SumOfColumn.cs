using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    class SumOfColumn
    {
        static void Main(string[] args)
        {
            int[,] a = { { 3, 4, 5 }, { 8, 6, 2 }, { 1, 2, 3 } };

            for(int i=0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for(int j =0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j, i];
                    Console.WriteLine(a[j,i]+" ");
                }
                Console.WriteLine(" sum= "+sum);
                Console.WriteLine();
            }
        }
    }
}
