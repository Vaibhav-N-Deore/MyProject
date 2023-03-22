using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ClassWorkArray
{
    internal class DuplicateEle
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {4, 5, 5, 7, 3, 9, 1 };
            int[] arr2 = new int[] { 4, 7, 4, 6, 3, 1, };
            int[] mergedarray = new int[arr1.Length + arr2.Length];
            int k = 0;

            bool Duplicate;

            for (int i = 0; i < arr1.Length; i++)
            {
                Duplicate = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Duplicate = true; 
                        break;
                    }
                }

                if (Duplicate == false)
                {
                    mergedarray[k++] = arr1[i];
                }   
            }

            for (int i = 1; i <= k; k++)
            {
                arr1[arr1.Length - k] = '\0';
            }


            Console.WriteLine("murgedarray[i]+" );
            Console.Read();
        }
    }

}
