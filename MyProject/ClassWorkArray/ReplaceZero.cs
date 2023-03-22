using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyProject.ClassWorkArray
{
    internal class ReplaceZero
    {
        int x;
        static void Main(string[] args)
        {
            int m,n,i,j,r,c;
            Console.WriteLine("enter no. of row and column");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());

            int[,] A = new int[10, 10];
            Console.Write("\nEnter 1st matrix :");

            for (i = 0; i < m; i++)
            {
                for(j=0; j<n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nmatrix A :");

            for(i = 0; i < m; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("\n setting zero "+"lower tringle matrix\n");

            for (i = 0; i < m; i++) 
            {
                Console.Write("\n");
                for(j=0; j<3; j++)
                {
                    if(i>=j)
                        Console.Write(A[i,j]+ "\t");
                    else
                        Console.Write("0\t");
                }
            }
            Console.ReadLine();

        }

    }
}
