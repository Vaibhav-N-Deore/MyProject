using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayAssignment
{
    internal class ReverseItSelf // Q.12.	WAP to reverse the array itself, don’t print array in reverse
                                 // – I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
                                 // so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 8, 2, 9, 5, 5 };

            int length = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[length - 1] + " ");
                length = length - 1;
            }
        }
    }
}

