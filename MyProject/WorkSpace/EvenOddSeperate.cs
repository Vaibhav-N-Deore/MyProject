using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WorkSpace
{
    internal class EvenOddSeperate
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];

            int i, j = 0, K = 0, n;

            Console.Write("Separate odd even \n ");

            Console.Write("inpute element to store :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("inpute {0} element in array\n ");
            for(i=0; i<n; i++)
            {
                Console.Write(" element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            

            for(i=0; i<n; i++)
            {
                if (arr1[i]%2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[K] = arr1[i];
                    K++;
                }
            }
            Console.Write("Even element are \n");
            for (i=0; i<j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.Write(" Odd element are \n");
            for(i=0; i<K; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.WriteLine("");

        }
    }

}
