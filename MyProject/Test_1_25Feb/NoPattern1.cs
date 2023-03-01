using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class No_Pattern1
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int n1 = 1;
            int n2 = 4;

            for (i = 1; i <= n2; i++)
            {
                for (j = n2 - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= n1; k++)
                {
                    Console.Write(i);
                }
                n1 += 2;
                Console.WriteLine();

            }   
        } 
    }
}
