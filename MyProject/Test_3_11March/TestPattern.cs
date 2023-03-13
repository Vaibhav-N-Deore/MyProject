using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_3_11March
{
    internal class TestPattern
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int m = 1;
            int n = 4;

            for (i = 1; i <= n; i++)
            {
                for (j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= m; k++)
                {
                    Console.Write(k);
                }
                 m += 2;
                Console.WriteLine();

            }
        }
    }
}


