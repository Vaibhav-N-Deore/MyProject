using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class MergeArray //Q.WAP to merge 2 arrays to 3rd array.
                              //3rd array should not have elements of same value
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 11, 12, 13 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length]; // int[] c={10};

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }

            for (int i = 0; i < c.Length; i++)
            {
                
                  Console.Write(c[i] + ",");
            }
            Console.ReadLine();
        }

    }
}



